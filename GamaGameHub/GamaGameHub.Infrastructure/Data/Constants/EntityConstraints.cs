using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Infrastructure.Data.Constants
{
    public static class EntityConstraints
    {
        public static class UserConstraints
        {
            public const int UserNameMaxLength = 50;
            public const int UserNameMinLength = 2;

            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 5;

            public const int CityMaxLength = 169;
            public const int CityMinLength = 1;

            public const int CountryMaxLength = 56;
            public const int CountryMinLength = 4;

            public const int EmailMaxLength = 50;
            public const int EmailMinLength = 10;
        }

        public static class PostConstraints
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 2;

            public const int ShortContentMaxLength = 150;
            public const int ShortContentMinLength = 10;

            public const int MainContentMaxLength = 5000;
            public const int MainContentMinLength = 50;
        }

        public static class PostCommentConstraints
        {
            public const int ContentMaxLength = 300;
            public const int ContentMinLength = 10;
        }

        public static class ReviewConstraints
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 2;

            public const int ShortContentMaxLength = 150;
            public const int ShortContentMinLength = 10;

            public const int MainContentMaxLength = 5000;
            public const int MainContentMinLength = 50;

            public const int StarsMax = 5;
            public const int StarsMin = 0;
        }

        public static class ReviewCommentConstraints
        {
            public const int ContentMaxLength = 300;
            public const int ContentMinLength = 10;
        }

        public static class GameCreatorConstraints
        {
            public const int AdditionalInformationMaxLength = 200;
            public const int AdditionalInformationMinLength = 10;
        }

        public static class GameConstraints
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 150;
            public const int DescriptionMinLength = 10;

            public const int StarsMax = 5;
            public const int StarsMin = 0;
        }

        public static class GenreConstraints
        {
            public const int NameMaxLength = 300;
            public const int NameMinLength = 10;

            public const int DescriptionMaxLength = 300;
            public const int DescriptionMinLength = 10;
        }

        public static class CategoryConstraints
        {
            public const int NameMaxLength = 300;
            public const int NameMinLength = 10;

            public const int DescriptionMaxLength = 300;
            public const int DescriptionMinLength = 10;
        }
    }
}
