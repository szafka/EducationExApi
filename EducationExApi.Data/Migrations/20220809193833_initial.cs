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
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CredentialsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUsers", x => x.userId);
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
                    BaseUseruserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_BaseUsers_BaseUseruserId",
                        column: x => x.BaseUseruserId,
                        principalTable: "BaseUsers",
                        principalColumn: "userId");
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
                values: new object[] { new Guid("ac0b5af3-7368-414a-b40c-ccb9c97adeae"), "admin", "admin", new byte[] { 233, 99, 4, 85, 217, 129, 48, 179, 169, 253, 34, 195, 73, 92, 164, 91, 177, 222, 45, 232, 195, 61, 18, 39, 117, 0, 89, 238, 164, 88, 210, 228, 54, 130, 11, 131, 229, 11, 189, 231, 32, 106, 160, 149, 184, 56, 76, 111, 177, 87, 226, 226, 224, 135, 105, 171, 219, 48, 44, 195, 244, 89, 61, 210 }, new byte[] { 155, 98, 207, 78, 105, 140, 243, 229, 95, 56, 39, 98, 203, 249, 177, 128, 180, 243, 232, 111, 49, 213, 145, 207, 61, 112, 105, 132, 88, 235, 139, 52, 164, 4, 174, 115, 0, 27, 140, 36, 164, 202, 76, 184, 3, 146, 155, 205, 234, 65, 78, 189, 170, 175, 45, 37, 145, 252, 130, 136, 164, 253, 162, 67, 130, 64, 170, 191, 145, 79, 13, 52, 241, 9, 215, 96, 51, 115, 162, 111, 156, 47, 165, 102, 112, 21, 32, 152, 138, 32, 139, 80, 34, 115, 51, 139, 165, 201, 39, 240, 22, 137, 220, 62, 50, 137, 217, 171, 95, 160, 33, 148, 86, 187, 71, 247, 131, 84, 34, 228, 215, 135, 116, 100, 152, 213, 139, 233 } });

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
                name: "IX_Reviews_BaseUseruserId",
                table: "Reviews",
                column: "BaseUseruserId");

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
