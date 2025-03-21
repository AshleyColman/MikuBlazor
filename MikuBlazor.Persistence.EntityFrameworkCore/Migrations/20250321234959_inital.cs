using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MikuBlazor.Persistence.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
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
                name: "Genre",
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
                    table.PrimaryKey("PK_Genre", x => x.Id);
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
                    Episodes = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProducerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "AnimeCharacter",
                schema: "App",
                columns: table => new
                {
                    AnimesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeCharacter", x => new { x.AnimesId, x.CharactersId });
                    table.ForeignKey(
                        name: "FK_AnimeCharacter_Animes_AnimesId",
                        column: x => x.AnimesId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeCharacter_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalSchema: "App",
                        principalTable: "Characters",
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
                name: "AnimeGenre",
                columns: table => new
                {
                    AnimesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenresId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeGenre", x => new { x.AnimesId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_AnimeGenre_Animes_AnimesId",
                        column: x => x.AnimesId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeGenre_Genre_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genre",
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
                        name: "FK_AnimeGenres_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeProducer",
                schema: "App",
                columns: table => new
                {
                    AnimesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProducersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeProducer", x => new { x.AnimesId, x.ProducersId });
                    table.ForeignKey(
                        name: "FK_AnimeProducer_Animes_AnimesId",
                        column: x => x.AnimesId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeProducer_Producers_ProducersId",
                        column: x => x.ProducersId,
                        principalSchema: "App",
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeStudio",
                schema: "App",
                columns: table => new
                {
                    AnimesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudiosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeStudio", x => new { x.AnimesId, x.StudiosId });
                    table.ForeignKey(
                        name: "FK_AnimeStudio_Animes_AnimesId",
                        column: x => x.AnimesId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeStudio_Studios_StudiosId",
                        column: x => x.StudiosId,
                        principalSchema: "App",
                        principalTable: "Studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeTag",
                schema: "App",
                columns: table => new
                {
                    AnimesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeTag", x => new { x.AnimesId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_AnimeTag_Animes_AnimesId",
                        column: x => x.AnimesId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalSchema: "App",
                        principalTable: "Tags",
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
                name: "ProducerAnimes",
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
                    table.PrimaryKey("PK_ProducerAnimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProducerAnimes_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProducerAnimes_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalSchema: "App",
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudioAnimes",
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
                    table.PrimaryKey("PK_StudioAnimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudioAnimes_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalSchema: "App",
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudioAnimes_Studios_StudioId",
                        column: x => x.StudioId,
                        principalSchema: "App",
                        principalTable: "Studios",
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

            migrationBuilder.CreateIndex(
                name: "IX_AnimeCharacter_CharactersId",
                schema: "App",
                table: "AnimeCharacter",
                column: "CharactersId");

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
                name: "IX_AnimeGenre_GenresId",
                table: "AnimeGenre",
                column: "GenresId");

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
                name: "IX_AnimeProducer_ProducersId",
                schema: "App",
                table: "AnimeProducer",
                column: "ProducersId");

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
                name: "IX_AnimeStudio_StudiosId",
                schema: "App",
                table: "AnimeStudio",
                column: "StudiosId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeTag_TagsId",
                schema: "App",
                table: "AnimeTag",
                column: "TagsId");

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
                name: "IX_ProducerAnimes_AnimeId",
                schema: "App",
                table: "ProducerAnimes",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducerAnimes_ProducerId",
                schema: "App",
                table: "ProducerAnimes",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_StudioAnimes_AnimeId",
                schema: "App",
                table: "StudioAnimes",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudioAnimes_StudioId",
                schema: "App",
                table: "StudioAnimes",
                column: "StudioId");

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
                name: "AnimeCharacter",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeCharacters",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeGenre");

            migrationBuilder.DropTable(
                name: "AnimeGenres",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeProducer",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeStudio",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeTag",
                schema: "App");

            migrationBuilder.DropTable(
                name: "AnimeTags",
                schema: "App");

            migrationBuilder.DropTable(
                name: "ProducerAnimes",
                schema: "App");

            migrationBuilder.DropTable(
                name: "StudioAnimes",
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
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Tags",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Producers",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Studios",
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
