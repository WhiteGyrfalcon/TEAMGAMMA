using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamaGameHub.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(169)", maxLength: 169, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameCreator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    YearOfCreating = table.Column<int>(type: "int", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCreator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameCreator_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GameCreatorId = table.Column<int>(type: "int", nullable: false),
                    AverageStars = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_GameCreator_GameCreatorId",
                        column: x => x.GameCreatorId,
                        principalTable: "GameCreator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameCreatorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MainContent = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_GameCreator_GameCreatorId",
                        column: x => x.GameCreatorId,
                        principalTable: "GameCreator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favourites_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => new { x.GameId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_GameCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameCategory_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameGenre",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenre", x => new { x.GenreId, x.GameId });
                    table.ForeignKey(
                        name: "FK_GameGenre_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MainContent = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostComments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReviewComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewComments_Review_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Review",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3023896d-3caf-4d3a-9812-36f654921534", "77b7cc1b-9bc2-4da9-b957-0aaac7acf796", "Administrator", "ADMINISTRATOR" },
                    { "37c6416c-0f8e-4820-92c6-ebd52c680c8f", "628696f8-15cc-4856-9158-b93faa1ec13c", "Client", "CLIENT" },
                    { "82254c24-56b0-4a91-9d25-9c43e89f9e92", "ba803d6b-1052-4814-bca4-3c132022a453", "GameCreator", "GAMECREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c88b9f1-b872-4450-a600-c36f736aeea9", 0, "Aleksandar Batenberg 28", "Karnobat", "8558378d-0864-4b34-8405-70c2303c5343", "Bulgaria", "petar@gmail.com", false, true, false, null, "PETAR@GMAIL.COM", "PETAR", "AQAAAAEAACcQAAAAEK0esQEd8y725LS/4xdn95hQJj4DBzLHIZoEcv9O6a9kuRQ8Tbx8cruUdaLdIatpGw==", "0893052673", false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE", "732f2bdf-9ad6-4d36-a41d-70e2156c0786", false, "petar" },
                    { "3d9a8eaf-5b3e-4b69-a101-74ff3787b7df", 0, "Redwood Shores Parkway 209", "Redwood City, Northern California", "ff5f11fc-e2f6-420e-ae2d-560e42decaf4", "USA", "electronicarts@gmail.com", false, true, false, null, "ELECTRONICARTS@GMAIL.COM", "ELECTRONIC ARTS", "AQAAAAEAACcQAAAAEJRojvaBvmyqnO7DhrEyVpluTeInxzGe41saxJ7gJQu14E+t8xP3r4uCYVS4iduP3A==", "16059719337", false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE", "ab083cd4-3ba0-4f33-9870-1f9268137747", false, "Electronic Arts" },
                    { "40b15c7b-dc76-4280-b025-4816f74e5f48", 0, "Metodii Kusev 32", "Stara Zagora", "717ee121-5fb0-4ea7-ab95-95111a443488", "Bulgaria", "gergana@gmail.com", false, true, false, null, "GERGANA@GMAIL.COM", "GERGANA", "AQAAAAEAACcQAAAAEH6Rc2hZ0dRfy2g9SSPky+Qb5pGa45tF+Ee2mjJ9leDlZTcysRr5xg7CWxAnENIhhg==", "0986999728", false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE", "d6bf9970-ffd4-4982-9858-b9e224793022", false, "gergana" },
                    { "7113b6b6-07d4-4d57-8173-2a9d053834d4", 0, "Hristo Botev 15", "Kazanlak", "53209afc-c75d-46ea-a259-537cfeb691ce", "Bulgaria", "silvia@gmail.com", false, true, false, null, "SILVIA@GMAIL.COM", "SILVIA", "AQAAAAEAACcQAAAAECQcoJjHEJIQgoGhO9afIjLo2DPKR8SzNOnzdP5Ydx46roQP2n3GLzQqOeZuxiHscA==", "0888752419", false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE", "3de16fe2-f98e-4a59-a66f-3c0270cf850b", false, "silvia" },
                    { "7cd7370d-565d-4f77-9fd5-60d27985bbf1", 0, "Main Street 22", "Toronto", "0b158b03-919c-46f7-8b54-ebb467d48899", "Canada", "bhvrinteractive@gmail.com", false, true, false, null, "BHVRINTERACTIVE@GMAIL.COM", "BEHAVIOUR INTERACTIVE INC.", "AQAAAAEAACcQAAAAEMw/kALbGjBLED9z5xAbuxg/AKI3k4fSKlrEwTY5xKk5a9JuoEn67TFgIhQK1FGmyw==", "136579373378", false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE", "c5a1da34-1485-4b30-9390-efa8475cd505", false, "Behaviour Interactive Inc." },
                    { "da389127-2cb6-4a2c-9afe-e609253e9391", 0, "Vasil Levski 8", "Varna", "cd1381e8-ac9a-4c9f-8f3e-a59ed1dd07ad", "Bulgaria", "stoyan@gmail.com", false, true, false, null, "STOYAN@GMAIL.COM", "STOYAN", "AQAAAAEAACcQAAAAENqAeD+1in3sIFi/+2t1I8dqtsIszR4i7GMAuc3iNgNItcoox9xm/c1KA5XMNwP82A==", "0898508050", false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.freeiconspng.com%2Fimages%2Fprofile-icon-png&psig=AOvVaw3wTqNvIRQgdxukevliNioM&ust=1701414266054000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCIi0rJmU64IDFQAAAAAdAAAAABAE", "da5ce624-7576-4157-b789-2c290bca13d4", false, "stoyan" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Shows the first 20 games, that have most likes.", "Top 20 most favourited games" },
                    { 2, "Shows 5 games, which have the most reviews.", "Top 5 most reviewed games" },
                    { 3, "Shows the first 25 adventure games, that have most likes.", "Top 25 adventure games" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "An action game is a video game genre that emphasizes physical challenges, including hand–eye coordination and reaction time. The genre includes a large variety of sub-genres, such as fighting games, beat 'em ups, shooter games, and platform games.", "Action" },
                    { 2, "An adventure game (rarely called a quest game) is a video game genre in which the player assumes the role of a protagonist in an interactive story, driven by exploration and/or puzzle-solving. Most adventure games are designed for a single player.", "Adventure" },
                    { 3, "Sports games are a video game genre that simulates sports. They are usually based on real-world sports, but can also be fictional or exaggerated. These games usually let the player control one or more athletes during competition.", "Sports" },
                    { 4, "Indie games stand for “independent video games.” At the highest level, they are games created by individuals or small teams who operate independently from major studios, both financially and creatively.", "Indie" },
                    { 5, "A casual game is a video game targeted at a mass market audience, as opposed to a hardcore game, which is targeted at hobbyist gamers. Casual games may exhibit any type of gameplay and genre. They generally involve simpler rules, shorter sessions, and require less learned skill.", "Casual" },
                    { 6, "Simulation games are a diverse super-category of video games, generally designed to closely simulate real world activities. A simulation game attempts to copy various activities from real life in the form of a game for various purposes such as training, analysis, prediction, or entertainment.", "Simulation" },
                    { 7, "Role-playing video game is electronic game genre in which players advance through a story quest, and often many side quests, for which their character or party of characters gain experience that improves various attributes and abilities.", "RPG" },
                    { 8, "A strategy game is a game in which the players' uncoerced, and often autonomous, decision-making skills have a high significance in determining the outcome. Almost all strategy games require internal decision tree-style thinking, and typically very high situational awareness.", "Strategy" },
                    { 9, "A massively multiplayer online game (MMOG or MMO) is an online video game with a large number of players on the same server. MMOs usually feature a huge, persistent open world, although there are games that differ. These games can be found for most network-capable platforms.", "Massively Multiplayer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "37c6416c-0f8e-4820-92c6-ebd52c680c8f", "2c88b9f1-b872-4450-a600-c36f736aeea9" },
                    { "82254c24-56b0-4a91-9d25-9c43e89f9e92", "3d9a8eaf-5b3e-4b69-a101-74ff3787b7df" },
                    { "3023896d-3caf-4d3a-9812-36f654921534", "40b15c7b-dc76-4280-b025-4816f74e5f48" },
                    { "3023896d-3caf-4d3a-9812-36f654921534", "7113b6b6-07d4-4d57-8173-2a9d053834d4" },
                    { "82254c24-56b0-4a91-9d25-9c43e89f9e92", "7cd7370d-565d-4f77-9fd5-60d27985bbf1" },
                    { "37c6416c-0f8e-4820-92c6-ebd52c680c8f", "da389127-2cb6-4a2c-9afe-e609253e9391" }
                });

            migrationBuilder.InsertData(
                table: "GameCreator",
                columns: new[] { "Id", "AdditionalInformation", "IsActive", "UserId", "YearOfCreating" },
                values: new object[,]
                {
                    { 1, "Driven by passion, we are a global leader in digital interactive entertainment. We develop and deliver games, content, and online services for Internet-connected consoles, mobile devices, and PCs.", true, "3d9a8eaf-5b3e-4b69-a101-74ff3787b7df", 1982 },
                    { 2, "Innovation is our business. We strongly believe in trying new tech, methods, and ideas. It’s the result that counts, not how we get there.", true, "7cd7370d-565d-4f77-9fd5-60d27985bbf1", 1992 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AverageStars", "CreatedOn", "Description", "GameCreatorId", "IsActive", "Name", "Thumbnail" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apex Legends is the award-winning, free-to-play Hero Shooter from Respawn Entertainment.", 1, true, "Apex Legends™", "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/2x1_NSwitchDS_ApexLegends_Season18_image1600w.jpg" },
                    { 2, 3, new DateTime(2016, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "A multiplayer horror game where one player takes on the role of the savage Killer, and other four players play as Survivors, trying to escape.", 2, true, "Dead by Daylight", "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_DeadByDaylight_image1280w.jpg" },
                    { 3, 5, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The World's Game: the most true-to-football experience ever with HyperMotionV, PlayStyles optimized by Opta, and an enhanced Frostbite™ Engine.", 1, true, "EA SPORTS FC™ 24", "https://image-cdn.essentiallysports.com/wp-content/uploads/EA-Sports-FC-24-1536x864.jpg" },
                    { 4, 2, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "First-person shooter, marks the return to the iconic warfare of the franchise. With a cutting-edge arsenal, you can engage in multiplayer battles.", 2, true, "Battlefield™ 2042", "https://assets.xboxservices.com/assets/71/99/71999807-558a-4640-b29a-cb13a721c4bd.jpg?n=299441_GLP-Page-Hero-0_1083x609.jpg" },
                    { 5, 2, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty is a franchise of several multiplayer first-person shooter games published by Activision.", 1, true, "Call of Duty", "https://xxboxnews.blob.core.windows.net/prod/sites/2/2022/06/Call-of-Duty-Modern-Warfare-II_Reveal_X1_Wire_Hero_1920x1080-b5aea4e5ca6046ac478e.jpg" },
                    { 6, 3, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open-world, action-adventure RPG set in the Night City, where you play as a cyberpunk mercenary wrapped up in a do-or-die fight for survival.", 2, true, "Cyberpunk 2077", "https://static.cdprojektred.com/cms.cdprojektred.com/16x9_big/b9ea2dc46d95cf9fa3f77209e27ae7a6488368f1-1920x1080.jpg" },
                    { 7, 5, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore a thrilling, open-world MMO filled with danger where you are an adventurer shipwrecked on the supernatural island of Aeternum.", 1, true, "New World", "https://images.ctfassets.net/j95d1p8hsuun/29peK2k7Ic6FsPAVjHWs8W/06d3add40b23b20bbff215f6979267e8/NW_OPENGRAPH_1200x630.jpg" },
                    { 8, 1, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the game's story mode, players assume the role of player character Master Chief, as he wages a war against the Banished, an alien faction.", 2, true, "Halo Infinite", "https://i.ytimg.com/vi/HZtc5-syeAk/maxresdefault.jpg" },
                    { 9, 4, new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Play as a paranormal investigator in our hybrid between first person survival and psychological horror story game.", 1, true, "The Devourer: Hunted Souls", "https://gamefabrique.ru/i/pc/the-devourer-hunted-souls.jpg" },
                    { 10, 3, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open-world high-fantasy strategy RPG that takes players on an epic journey where they can discover a dynamic world.", 2, true, "Dragonheir: Silent Gods", "https://i.ytimg.com/vi/OQFjIlOFJkg/maxresdefault.jpg" }
                });

            migrationBuilder.InsertData(
                table: "GameCategory",
                columns: new[] { "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 1, 6 },
                    { 3, 6 },
                    { 1, 7 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 8 },
                    { 1, 9 },
                    { 3, 9 },
                    { 1, 10 },
                    { 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "GameGenre",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 1, 2 },
                    { 4, 2 },
                    { 7, 2 },
                    { 9, 2 },
                    { 3, 3 },
                    { 9, 4 },
                    { 4, 5 },
                    { 3, 6 },
                    { 6, 7 },
                    { 7, 7 },
                    { 10, 7 },
                    { 10, 8 },
                    { 7, 9 },
                    { 10, 9 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "GameId", "IsActive", "PostId", "UrlPath" },
                values: new object[,]
                {
                    { 1, 1, true, null, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/2x1_NSwitchDS_ApexLegends_Season18_image1600w.jpg" },
                    { 2, 2, true, null, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_DeadByDaylight_image1280w.jpg" },
                    { 3, 3, true, null, "https://image-cdn.essentiallysports.com/wp-content/uploads/EA-Sports-FC-24-1536x864.jpg" },
                    { 4, 4, true, null, "https://assets.xboxservices.com/assets/71/99/71999807-558a-4640-b29a-cb13a721c4bd.jpg?n=299441_GLP-Page-Hero-0_1083x609.jpg" },
                    { 5, 5, true, null, "https://xxboxnews.blob.core.windows.net/prod/sites/2/2022/06/Call-of-Duty-Modern-Warfare-II_Reveal_X1_Wire_Hero_1920x1080-b5aea4e5ca6046ac478e.jpg" },
                    { 6, 6, true, null, "https://static.cdprojektred.com/cms.cdprojektred.com/16x9_big/b9ea2dc46d95cf9fa3f77209e27ae7a6488368f1-1920x1080.jpg" },
                    { 7, 7, true, null, "https://images.ctfassets.net/j95d1p8hsuun/29peK2k7Ic6FsPAVjHWs8W/06d3add40b23b20bbff215f6979267e8/NW_OPENGRAPH_1200x630.jpg" },
                    { 8, 8, true, null, "https://i.ytimg.com/vi/HZtc5-syeAk/maxresdefault.jpg" },
                    { 9, 9, true, null, "https://gamefabrique.ru/i/pc/the-devourer-hunted-souls.jpg" },
                    { 10, 10, true, null, "https://i.ytimg.com/vi/OQFjIlOFJkg/maxresdefault.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_GameId",
                table: "Favourites",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GameCategory_CategoryId",
                table: "GameCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GameCreator_UserId",
                table: "GameCreator",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGenre_GameId",
                table: "GameGenre",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameCreatorId",
                table: "Games",
                column: "GameCreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_GameId",
                table: "Images",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PostId",
                table: "Images",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_PostId",
                table: "PostComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_UserId",
                table: "PostComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_GameCreatorId",
                table: "Posts",
                column: "GameCreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_GameId",
                table: "Review",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewComments_ReviewId",
                table: "ReviewComments",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewComments_UserId",
                table: "ReviewComments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "GameCategory");

            migrationBuilder.DropTable(
                name: "GameGenre");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "ReviewComments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "GameCreator");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
