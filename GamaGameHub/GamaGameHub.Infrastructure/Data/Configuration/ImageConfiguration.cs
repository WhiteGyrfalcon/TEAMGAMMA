using GamaGameHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(CreateImages());
        }
        internal List<Image> CreateImages()
        {
            var images = new List<Image>();

            var image = new Image()
            {
                Id = 1,
                UrlPath = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/2x1_NSwitchDS_ApexLegends_Season18_image1600w.jpg",
                IsActive = true,
                GameId = 1
            };

            images.Add(image);

            image = new Image()
            {
                Id = 2,
                UrlPath = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_DeadByDaylight_image1280w.jpg",
                IsActive = true,
                GameId = 2
            };

            images.Add(image);

            image = new Image()
            {
                Id = 3,
                UrlPath = "https://image-cdn.essentiallysports.com/wp-content/uploads/EA-Sports-FC-24-1536x864.jpg",
                IsActive = true,
                GameId = 3
            };

            images.Add(image);

            image = new Image()
            {
                Id = 4,
                UrlPath = "https://assets.xboxservices.com/assets/71/99/71999807-558a-4640-b29a-cb13a721c4bd.jpg?n=299441_GLP-Page-Hero-0_1083x609.jpg",
                IsActive = true,
                GameId = 4
            };

            images.Add(image);

            image = new Image()
            {
                Id = 5,
                UrlPath = "https://xxboxnews.blob.core.windows.net/prod/sites/2/2022/06/Call-of-Duty-Modern-Warfare-II_Reveal_X1_Wire_Hero_1920x1080-b5aea4e5ca6046ac478e.jpg",
                IsActive = true,
                GameId = 5
            };

            images.Add(image);

            image = new Image()
            {
                Id = 6,
                UrlPath = "https://static.cdprojektred.com/cms.cdprojektred.com/16x9_big/b9ea2dc46d95cf9fa3f77209e27ae7a6488368f1-1920x1080.jpg",
                IsActive = true,
                GameId = 6
            };

            images.Add(image);

            image = new Image()
            {
                Id = 7,
                UrlPath = "https://images.ctfassets.net/j95d1p8hsuun/29peK2k7Ic6FsPAVjHWs8W/06d3add40b23b20bbff215f6979267e8/NW_OPENGRAPH_1200x630.jpg",
                IsActive = true,
                GameId = 7
            };

            images.Add(image);

            image = new Image()
            {
                Id = 8,
                UrlPath = "https://i.ytimg.com/vi/HZtc5-syeAk/maxresdefault.jpg",
                IsActive = true,
                GameId = 8
            };

            images.Add(image);

            image = new Image()
            {
                Id = 9,
                UrlPath = "https://gamefabrique.ru/i/pc/the-devourer-hunted-souls.jpg",
                IsActive = true,
                GameId = 9
            };

            images.Add(image);

            image = new Image()
            {
                Id = 10,
                UrlPath = "https://i.ytimg.com/vi/OQFjIlOFJkg/maxresdefault.jpg",
                IsActive = true,
                GameId = 10
            };

            images.Add(image);

            return images;
        }
    }
}
