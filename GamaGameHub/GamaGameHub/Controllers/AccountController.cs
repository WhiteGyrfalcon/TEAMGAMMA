﻿using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Models.Account;
using GamaGameHub.Core.Models.User;
using GamaGameHub.Extensions;
using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GamaGameHub.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IImageService imageService;
        private readonly IUserService userService;
        private readonly IGameCreatorService gameCreatorService;

        public AccountController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager,
            IImageService _imageService,
            IUserService _userService,
            IGameCreatorService _gameCreatorService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            imageService = _imageService;
            userService = _userService;
            gameCreatorService = _gameCreatorService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (await userService.UserByEmailExists(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "There is already a registration with this email!");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                Email = model.Email,
                UserName = model.Username,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                City = model.City,
                Country = model.Country
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (model.AdditionalInformation != null || model.YearOfCreating != 0)
            {
                await gameCreatorService.Create(user.Id, model.AdditionalInformation, model.YearOfCreating);
                await userManager.AddToRoleAsync(user, "GameCreator");
            }
            else
            {
                await userManager.AddToRoleAsync(user, "Client");
            }

            if (model.ProfilePicture != null)
            {
                user.ProfilePictureUrl = await this.imageService.UploadImage(model.ProfilePicture, "images", user);
                await userManager.UpdateAsync(user);
            }
            await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.Code, item.Description);//gospodina pipa ne bqh az ako gramne
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                if (user.IsActive)
                {

                    var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            GameCreatorModel profile = await gameCreatorService.GetGameCreatorByUserId(this.User.Id());
            return View(profile);
        }

        [HttpPost]
        public async Task<IActionResult> Profile(GameCreatorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);
            user.UserName = model.Username;
            user.PhoneNumber = model.PhoneNumber;
            user.Address = model.Address;
            user.City = model.City;
            user.Country = model.Country;

            var result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.Code, item.Description);
            }

            result = await userManager.UpdateAsync(user);
            if (await userManager.IsInRoleAsync(user, "GameCreator"))
            {
                await gameCreatorService.Update(this.User.Id(), model.AdditionalInformation, model.YearOfCreating);
            }

            if (result.Succeeded)
            {
                await signInManager.RefreshSignInAsync(user);
                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.Code, item.Description);
            }

            return View(model);
        }
    }
}
