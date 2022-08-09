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
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "BaseUsers",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CredentialsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUsers", x => x.Name);
                    table.ForeignKey(
                        name: "FK_BaseUsers_CredentialsContainers_CredentialsId",
                        column: x => x.CredentialsId,
                        principalTable: "CredentialsContainers",
                        principalColumn: "CredentialsId");
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "date", nullable: true),
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
                    BaseUserName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_BaseUsers_BaseUserName",
                        column: x => x.BaseUserName,
                        principalTable: "BaseUsers",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Reviews_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "CredentialsContainers",
                columns: new[] { "CredentialsId", "Login", "Password", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("ac0b5af3-7368-414a-b40c-ccb9c97adeae"), "admin", "admin", new byte[] { 205, 174, 150, 137, 81, 55, 197, 124, 93, 80, 46, 108, 244, 41, 178, 37, 177, 201, 241, 238, 82, 147, 64, 81, 78, 35, 173, 179, 64, 253, 210, 163, 107, 144, 59, 119, 230, 110, 28, 122, 13, 160, 174, 66, 222, 82, 41, 102, 116, 206, 210, 213, 12, 189, 142, 35, 178, 145, 235, 129, 207, 140, 22, 55 }, new byte[] { 115, 222, 235, 92, 101, 188, 71, 145, 30, 157, 198, 182, 0, 152, 156, 50, 70, 76, 140, 231, 62, 55, 224, 36, 38, 100, 35, 85, 94, 22, 29, 128, 225, 209, 137, 108, 72, 80, 18, 207, 233, 97, 11, 240, 91, 181, 186, 144, 62, 169, 177, 252, 254, 22, 194, 13, 51, 49, 53, 144, 249, 12, 221, 202, 44, 56, 229, 112, 185, 54, 189, 242, 105, 134, 152, 201, 161, 150, 120, 71, 19, 94, 7, 217, 19, 218, 93, 25, 147, 34, 12, 52, 41, 182, 59, 27, 40, 237, 36, 153, 246, 231, 105, 235, 222, 58, 61, 48, 83, 148, 68, 199, 111, 248, 157, 86, 61, 210, 56, 55, 235, 86, 251, 3, 161, 6, 246, 245 } });

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
                name: "IX_BaseUsers_CredentialsId",
                table: "BaseUsers",
                column: "CredentialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_AuthorId",
                table: "Materials",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialTypeId",
                table: "Materials",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BaseUserName",
                table: "Reviews",
                column: "BaseUserName");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MaterialId",
                table: "Reviews",
                column: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "BaseUsers");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "CredentialsContainers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "MaterialTypes");
        }
    }
}
