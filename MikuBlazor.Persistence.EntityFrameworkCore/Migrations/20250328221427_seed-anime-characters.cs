using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MikuBlazor.Persistence.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class seedanimecharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "App",
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("52a764e6-8be8-4841-8df0-8d16577b38ae"));

            migrationBuilder.DeleteData(
                schema: "App",
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("48948095-87f3-4a9e-8e25-ccb7c99e5d1e"));

            migrationBuilder.DeleteData(
                schema: "App",
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("06cedd70-9ce0-4ffe-88f6-f1392eeff6a1"));

            migrationBuilder.DeleteData(
                schema: "App",
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0f1b80d6-cca6-4a99-ab46-8af345a3f0ae"));

            migrationBuilder.InsertData(
                schema: "App",
                table: "Animes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "EndDate", "GenreId", "IsDeleted", "JapaneseTitle", "ProducerId", "Rank", "Rating", "SeasonId", "StartDate", "StatusId", "StudioId", "Title", "TypeId", "UpdatedBy", "UpdatedOn", "ViewerRatingId" },
                values: new object[] { new Guid("384521bc-e602-4257-bb99-ab991fc81211"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 4, 25, 22, 14, 27, 663, DateTimeKind.Local).AddTicks(4441), new Guid("24920bf5-f900-4cc9-b162-cbd6b6ed4b63"), false, "Sousou no Frieren", new Guid("afac5689-7c69-4fbe-b3aa-b24312906156"), 1, (byte)10, new Guid("721087fe-7f30-402e-a3f7-630d72456dc3"), new DateTime(2025, 3, 28, 22, 14, 27, 663, DateTimeKind.Local).AddTicks(4405), new Guid("c3336d32-7e62-4206-bbe0-0237a5a98ffc"), new Guid("de315bc7-62ab-4de9-8bdf-85d6e7b36ea4"), "Frieren: Beyond Journey's End", new Guid("21ec66be-5dc3-46c3-bd2a-3d71e15f9585"), new Guid("00000000-0000-0000-0000-000000000000"), null, new Guid("0ce556d2-a10a-471a-a2c2-ca19622012ee") });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Characters",
                columns: new[] { "Id", "Age", "CreatedBy", "CreatedOn", "DeletedBy", "Description", "FirstName", "GenderId", "ImageUri", "IsDeleted", "JapaneseName", "LastName", "NickName", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("2e013574-3613-4d12-b185-372071ca0899"), 1000, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frieren is a powerful warrior who has lived for over 1000 years. She is known as the Slayer and is feared by many.", "Frieren", new Guid("c0304b45-7bbb-40c9-b5f5-bf3dc9e3e564"), "https://cdn.myanimelist.net/images/characters/16/366547.jpg", false, "フリーレン", "", "Frieren the Slayer", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Episodes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "Description", "IsDeleted", "Number", "Title", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("dfb27088-1c87-484a-8324-5cdd8876475f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Episode 1description", false, 1, "Episode 1", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Tags",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("561c8fdd-90d1-4726-a154-3abf9b9bddd8"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fantasy", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "AnimeCharacters",
                columns: new[] { "Id", "AnimeId", "CharacterId", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("32eedd06-d795-4cc3-abc4-8c6789d69e5f"), new Guid("384521bc-e602-4257-bb99-ab991fc81211"), new Guid("2e013574-3613-4d12-b185-372071ca0899"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "App",
                table: "AnimeCharacters",
                keyColumn: "Id",
                keyValue: new Guid("32eedd06-d795-4cc3-abc4-8c6789d69e5f"));

            migrationBuilder.DeleteData(
                schema: "App",
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("dfb27088-1c87-484a-8324-5cdd8876475f"));

            migrationBuilder.DeleteData(
                schema: "App",
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("561c8fdd-90d1-4726-a154-3abf9b9bddd8"));

            migrationBuilder.DeleteData(
                schema: "App",
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("384521bc-e602-4257-bb99-ab991fc81211"));

            migrationBuilder.DeleteData(
                schema: "App",
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("2e013574-3613-4d12-b185-372071ca0899"));

            migrationBuilder.InsertData(
                schema: "App",
                table: "Animes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "EndDate", "GenreId", "IsDeleted", "JapaneseTitle", "ProducerId", "Rank", "Rating", "SeasonId", "StartDate", "StatusId", "StudioId", "Title", "TypeId", "UpdatedBy", "UpdatedOn", "ViewerRatingId" },
                values: new object[] { new Guid("52a764e6-8be8-4841-8df0-8d16577b38ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 4, 25, 22, 9, 12, 113, DateTimeKind.Local).AddTicks(2111), new Guid("24920bf5-f900-4cc9-b162-cbd6b6ed4b63"), false, "Sousou no Frieren", new Guid("afac5689-7c69-4fbe-b3aa-b24312906156"), 1, (byte)10, new Guid("721087fe-7f30-402e-a3f7-630d72456dc3"), new DateTime(2025, 3, 28, 22, 9, 12, 113, DateTimeKind.Local).AddTicks(2023), new Guid("c3336d32-7e62-4206-bbe0-0237a5a98ffc"), new Guid("de315bc7-62ab-4de9-8bdf-85d6e7b36ea4"), "Frieren: Beyond Journey's End", new Guid("21ec66be-5dc3-46c3-bd2a-3d71e15f9585"), new Guid("00000000-0000-0000-0000-000000000000"), null, new Guid("0ce556d2-a10a-471a-a2c2-ca19622012ee") });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Characters",
                columns: new[] { "Id", "Age", "CreatedBy", "CreatedOn", "DeletedBy", "Description", "FirstName", "GenderId", "ImageUri", "IsDeleted", "JapaneseName", "LastName", "NickName", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("48948095-87f3-4a9e-8e25-ccb7c99e5d1e"), 1000, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frieren is a powerful warrior who has lived for over 1000 years. She is known as the Slayer and is feared by many.", "Frieren", new Guid("c0304b45-7bbb-40c9-b5f5-bf3dc9e3e564"), "https://cdn.myanimelist.net/images/characters/16/366547.jpg", false, "フリーレン", "", "Frieren the Slayer", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Episodes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "Description", "IsDeleted", "Number", "Title", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("06cedd70-9ce0-4ffe-88f6-f1392eeff6a1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Episode 1description", false, 1, "Episode 1", new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                schema: "App",
                table: "Tags",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "IsDeleted", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("0f1b80d6-cca6-4a99-ab46-8af345a3f0ae"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fantasy", new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
