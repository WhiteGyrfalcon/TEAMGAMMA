using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamaGameHub.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        public GameController()
        {
            
        }
    }
}
