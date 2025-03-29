using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MikuBlazor.Persistence.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class schemaupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "App");

            migrationBuilder.CreateTable(
                name: "AnimeStatuses",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimeTypes",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViewerRatings",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewerRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JapaneseName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    ImageUri = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Genders_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "App",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animes",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    JapaneseTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ViewerRatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animes_AnimeStatuses_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "App",
                        principalTable: "AnimeStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animes_AnimeTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "App",
                        principalTable: "AnimeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalSchema: "App",
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animes_ViewerRatings_ViewerRatingId",
                        column: x => x.ViewerRatingId,
                        principalSchema: "App",
                        principalTable: "ViewerRatings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeCharacters",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeCharacters_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeCharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalSchema: "App",
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeEpisodes",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EpisodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeEpisodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeEpisodes_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeEpisodes_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalSchema: "App",
                        principalTable: "Episodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeGenres",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeGenres_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "App",
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeProducers",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProducerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeProducers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeProducers_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeProducers_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalSchema: "App",
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeStudios",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeStudios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeStudios_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeStudios_Studios_StudioId",
                        column: x => x.StudioId,
                        principalSchema: "App",
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeTags",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeTags_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeTags_Tags_TagId",
                        column: x => x.TagId,
                        principalSchema: "App",
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnimeFavourites",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnimeFavourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnimeFavourites_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnimeFavourites_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "App",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAnimeRatings",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnimeRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnimeRatings_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAnimeRatings_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "App",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCharacterFavourites",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCharacterFavourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCharacterFavourites_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCharacterFavourites_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalSchema: "App",
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCharacterFavourites_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "App",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeStatuses",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("c3336d32-7e62-4206-bbe0-0237a5a98ffc"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Airing", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("21ec66be-5dc3-46c3-bd2a-3d71e15f9585"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "TV", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Episodes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "Description", "IsDeleted", "Number", "Title", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("38c6c10a-83f8-418f-9115-4ec657214252"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Episode 1description", false, 1, "Episode 1", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Genders",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("1104f3d3-dd59-40c1-9536-763a4b5ad217"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Other", new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c76b669-f696-478c-8c34-6ac5144526f7"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Male", new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c0304b45-7bbb-40c9-b5f5-bf3dc9e3e564"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Female", new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Genres",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("24920bf5-f900-4cc9-b162-cbd6b6ed4b63"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fantasy", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Producers",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("afac5689-7c69-4fbe-b3aa-b24312906156"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Aniplex", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Seasons",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("721087fe-7f30-402e-a3f7-630d72456dc3"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fall2025", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Studios",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("de315bc7-62ab-4de9-8bdf-85d6e7b36ea4"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Madhouse", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Tags",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("2ff32451-d154-41fe-86b3-7159feaf5855"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fantasy", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "ViewerRatings",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("0ce556d2-a10a-471a-a2c2-ca19622012ee"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "PG13", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Animes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "EndDate", "IsDeleted", "JapaneseTitle", "Rank", "Rating", "SeasonId", "StartDate", "StatusId", "Title", "TypeId", "UpdatedBy", "UpdatedOn", "ViewerRatingId" },
                values: new object[] { new Guid("4aff0276-f322-42ec-b75b-f64851ecfc5e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 4, 25, 23, 3, 30, 180, DateTimeKind.Local).AddTicks(8031), false, "Sousou no Frieren", 1, (byte)10, new Guid("721087fe-7f30-402e-a3f7-630d72456dc3"), new DateTime(2025, 3, 28, 23, 3, 30, 180, DateTimeKind.Local).AddTicks(7995), new Guid("c3336d32-7e62-4206-bbe0-0237a5a98ffc"), "Frieren: Beyond Journey's End", new Guid("21ec66be-5dc3-46c3-bd2a-3d71e15f9585"), new Guid("00000000-0000-0000-0000-000000000000"), null, new Guid("0ce556d2-a10a-471a-a2c2-ca19622012ee") });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Characters",
                columns: new[] { "Id", "Age", "CreatedBy", "CreatedOn", "DeletedBy", "Description", "FirstName", "GenderId", "ImageUri", "IsDeleted", "JapaneseName", "LastName", "NickName", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("5eb1fdf3-a2c4-4fb1-b092-afb34fc5a4aa"), 1000, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frieren is a powerful warrior who has lived for over 1000 years. She is known as the Slayer and is feared by many.", "Frieren", new Guid("c0304b45-7bbb-40c9-b5f5-bf3dc9e3e564"), "https://cdn.myanimelist.net/images/characters/16/366547.jpg", false, "フリーレン", "", "Frieren the Slayer", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeCharacters",
                columns: new[] { "Id", "AnimeId", "CharacterId", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("ce9991e3-f300-48be-b5eb-7465cbb3fd1c"), new Guid("4aff0276-f322-42ec-b75b-f64851ecfc5e"), new Guid("5eb1fdf3-a2c4-4fb1-b092-afb34fc5a4aa"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeEpisodes",
                columns: new[] { "Id", "AnimeId", "CreatedBy", "CreatedOn", "DeletedBy", "EpisodeId", "IsDeleted", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("a9c6393b-166a-481b-8c8b-c99d2c3d127c"), new Guid("4aff0276-f322-42ec-b75b-f64851ecfc5e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("38c6c10a-83f8-418f-9115-4ec657214252"), false, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeGenres",
                columns: new[] { "Id", "AnimeId", "CreatedBy", "CreatedOn", "DeletedBy", "GenreId", "IsDeleted", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("c186a612-6fe3-4428-a44f-42ff59c18965"), new Guid("4aff0276-f322-42ec-b75b-f64851ecfc5e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("24920bf5-f900-4cc9-b162-cbd6b6ed4b63"), false, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeProducers",
                columns: new[] { "Id", "AnimeId", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "ProducerId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("0746258c-aac3-40e7-8247-1fab6e038822"), new Guid("4aff0276-f322-42ec-b75b-f64851ecfc5e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new Guid("afac5689-7c69-4fbe-b3aa-b24312906156"), new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeStudios",
                columns: new[] { "Id", "AnimeId", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "StudioId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("0a3cc2fb-69c5-4aae-ac5e-76253b0d9959"), new Guid("4aff0276-f322-42ec-b75b-f64851ecfc5e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new Guid("de315bc7-62ab-4de9-8bdf-85d6e7b36ea4"), new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeTags",
                columns: new[] { "Id", "AnimeId", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "TagId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("7caf0ffa-78f1-4933-a97c-3f8f45a266b5"), new Guid("4aff0276-f322-42ec-b75b-f64851ecfc5e"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new Guid("2ff32451-d154-41fe-86b3-7159feaf5855"), new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeCharacters_AnimeId",
                schema: "App",
                table: "AnimeCharacters",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeCharacters_CharacterId",
                schema: "App",
                table: "AnimeCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeEpisodes_AnimeId",
                schema: "App",
                table: "AnimeEpisodes",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeEpisodes_EpisodeId",
                schema: "App",
                table: "AnimeEpisodes",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeGenres_AnimeId",
                schema: "App",
                table: "AnimeGenres",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeGenres_GenreId",
                schema: "App",
                table: "AnimeGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeProducers_AnimeId",
                schema: "App",
                table: "AnimeProducers",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeProducers_ProducerId",
                schema: "App",
                table: "AnimeProducers",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Animes_SeasonId",
                schema: "App",
                table: "Animes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Animes_StatusId",
                schema: "App",
                table: "Animes",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Animes_TypeId",
                schema: "App",
                table: "Animes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Animes_ViewerRatingId",
                schema: "App",
                table: "Animes",
                column: "ViewerRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeStudios_AnimeId",
                schema: "App",
                table: "AnimeStudios",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeStudios_StudioId",
                schema: "App",
                table: "AnimeStudios",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeTags_AnimeId",
                schema: "App",
                table: "AnimeTags",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeTags_TagId",
                schema: "App",
                table: "AnimeTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_GenderId",
                schema: "App",
                table: "Characters",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimeFavourites_AnimeId",
                schema: "App",
                table: "UserAnimeFavourites",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimeFavourites_UserId",
                schema: "App",
                table: "UserAnimeFavourites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimeRatings_AnimeId",
                schema: "App",
                table: "UserAnimeRatings",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnimeRatings_UserId",
                schema: "App",
                table: "UserAnimeRatings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCharacterFavourites_AnimeId",
                schema: "App",
                table: "UserCharacterFavourites",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCharacterFavourites_CharacterId",
                schema: "App",
                table: "UserCharacterFavourites",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCharacterFavourites_UserId",
                schema: "App",
                table: "UserCharacterFavourites",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeCharacters",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeEpisodes",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeGenres",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeProducers",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeStudios",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeTags",
                schema: "App");

            migrationBuilder.DropTable(
                name: "UserAnimeFavourites",
                schema: "App");

            migrationBuilder.DropTable(
                name: "UserAnimeRatings",
                schema: "App");

            migrationBuilder.DropTable(
                name: "UserCharacterFavourites",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Episodes",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Genres",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Producers",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Studios",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Tags",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Animes",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Characters",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeStatuses",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeTypes",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Seasons",
                schema: "App");

            migrationBuilder.DropTable(
                name: "ViewerRatings",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "App");
        }
    }
}
