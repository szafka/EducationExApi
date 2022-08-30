using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationExApi.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "CredentialsContainers",
                columns: table => new
                {
                    CredentialsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialsContainers", x => x.CredentialsId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "date", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                    table.ForeignKey(
                        name: "FK_Materials_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materials_MaterialTypes_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "MaterialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "AdminId");
                    table.ForeignKey(
                        name: "FK_Reviews_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Login", "Password" },
                values: new object[] { 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Master of quantum physics", "Albert Einstein" },
                    { 2, "Master of Chemistry", "Maria Skłodowska-Curie" },
                    { 3, "Actor, pirate", "Johny Deep" },
                    { 4, "Galactic rider of yellow magnetic star", "Szafarz" }
                });

            migrationBuilder.InsertData(
                table: "MaterialTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { 1, "Outline of definition in .pdf type file", "Pdf file" },
                    { 2, "Ebook-materil with lectures read by the author", "Ebook" },
                    { 3, "Video-tutorial with developed step-by-step examples", "Video" },
                    { 4, "WorkBook with definitions, samples, excersices, answers", "WorkBook" },
                    { 5, "Power Point presentation material", "Presentation" },
                    { 6, "Database file with seeder", "Database file script" },
                    { 7, "Lecture outline with materials from lecture", "Lecture outline" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "AuthorId", "Description", "Location", "MaterialTypeId", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Structure of atom", "codecoolʼs library at Ślusarska 9", 1, new DateTime(1991, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structur of atom" },
                    { 2, 1, "Listen exploding atom sounds", "codecoolʼs library at Ślusarska 9", 2, new DateTime(1992, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atom sounds" },
                    { 3, 2, "Video-tutorial how to make taste drink", "codecoolʼs library at Ślusarska 9", 3, new DateTime(1993, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taste drink" },
                    { 4, 2, "Excersice how to check skin structure", "codecoolʼs library at Ślusarska 9", 4, new DateTime(1994, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skin structure" },
                    { 5, 2, "Radiate presentation", "codecoolʼs library at Ślusarska 9", 5, new DateTime(1995, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Radiate" },
                    { 6, 3, "Database of hollywood actors created by Johny Deep Entertaitnment", "codecoolʼs library at Ślusarska 9", 6, new DateTime(1996, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hollywood" },
                    { 7, 3, "Lecture outline, subcject: what can we do to be a good pirate", "codecoolʼs library at Ślusarska 9", 7, new DateTime(1997, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good pirate" },
                    { 8, 3, "Lecture in pdf how to be a good pirate", "codecoolʼs library at Ślusarska 9", 1, new DateTime(1998, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good pirate pdf" },
                    { 9, 3, "Ebook with sounds of Johny Deep as a pirate", "codecoolʼs library at Ślusarska 9", 2, new DateTime(1999, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirate sounds" },
                    { 10, 4, "Space tour video", "codecoolʼs library at Ślusarska 9", 3, new DateTime(1900, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Space tour" },
                    { 11, 4, "Create with me small satelite", "codecoolʼs library at Ślusarska 9", 4, new DateTime(1909, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satelite" },
                    { 12, 4, "Power Point Presentation about Sun", "codecoolʼs library at Ślusarska 9", 5, new DateTime(1987, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sun" },
                    { 13, 4, "Database with hole galactic", "codecoolʼs library at Ślusarska 9", 6, new DateTime(1955, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galactic" },
                    { 14, 4, "Lecture about galactic structure", "codecoolʼs library at Ślusarska 9", 7, new DateTime(1944, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galactic structure" },
                    { 15, 4, "Definitions of cosmos", "codecoolʼs library at Ślusarska 9", 1, new DateTime(1966, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cosmos" },
                    { 16, 3, "Johny Deep is reading pirates book", "codecoolʼs library at Ślusarska 9", 2, new DateTime(1972, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ebook pirate" },
                    { 17, 1, "Video how to create own tesla generator", "codecoolʼs library at Ślusarska 9", 3, new DateTime(1911, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tesla generator" },
                    { 18, 2, "Exercices with radiation", "codecoolʼs library at Ślusarska 9", 4, new DateTime(1915, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Radiation" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_AuthorId",
                table: "Materials",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialTypeId",
                table: "Materials",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AdminId",
                table: "Reviews",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MaterialId",
                table: "Reviews",
                column: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CredentialsContainers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "MaterialTypes");
        }
    }
}
