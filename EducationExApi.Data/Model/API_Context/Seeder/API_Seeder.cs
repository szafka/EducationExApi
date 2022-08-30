using System.Security.Cryptography;
using System.Text;

namespace EducationExApi.Data.Model.API_Context.Seeder
{
    public static class API_Seeder
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            //Authors
            var authorsList = new List<Author>();
            authorsList.Add(new Author { AuthorId = 1, Name = "Albert Einstein", Description = "Master of quantum physics" });
            authorsList.Add(new Author { AuthorId = 2, Name = "Maria Skłodowska-Curie", Description = "Master of Chemistry" });
            authorsList.Add(new Author { AuthorId = 3, Name = "Johny Deep", Description = "Actor, pirate" });
            authorsList.Add(new Author { AuthorId = 4, Name = "Szafarz", Description = "Galactic rider of yellow magnetic star" });
            modelBuilder.Entity<Author>().HasData(authorsList);
            //
            //Material type seeder
            var materialTypeList = new List<MaterialType>();
            materialTypeList.Add(new MaterialType { Id = 1, Type = "Pdf file", Description = "Outline of definition in .pdf type file" });
            materialTypeList.Add(new MaterialType { Id = 2, Type = "Ebook", Description = "Ebook-materil with lectures read by the author" });
            materialTypeList.Add(new MaterialType { Id = 3, Type = "Video", Description = "Video-tutorial with developed step-by-step examples" });
            materialTypeList.Add(new MaterialType { Id = 4, Type = "WorkBook", Description = "WorkBook with definitions, samples, excersices, answers" });
            materialTypeList.Add(new MaterialType { Id = 5, Type = "Presentation", Description = "Power Point presentation material" });
            materialTypeList.Add(new MaterialType { Id = 6, Type = "Database file script", Description = "Database file with seeder" });
            materialTypeList.Add(new MaterialType { Id = 7, Type = "Lecture outline", Description = "Lecture outline with materials from lecture" });
            modelBuilder.Entity<MaterialType>().HasData(materialTypeList);
            //
            
            
            //Materials
            var materialsList = new List<Material>();
            materialsList.Add(new Material { Title = "Structur of atom", AuthorId = 1, MaterialId = 1, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 1, Description = "Structure of atom", PublicationDate = new DateTime(1991, 05, 03) });
            materialsList.Add(new Material { Title = "Atom sounds", AuthorId = 1, MaterialId = 2, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 2, Description = "Listen exploding atom sounds", PublicationDate = new DateTime(1992, 05, 03) });
            materialsList.Add(new Material { Title = "Taste drink", AuthorId = 2, MaterialId = 3, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 3, Description = "Video-tutorial how to make taste drink", PublicationDate = new DateTime(1993, 05, 03) });
            materialsList.Add(new Material { Title = "Skin structure", AuthorId = 2, MaterialId = 4, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 4, Description = "Excersice how to check skin structure", PublicationDate = new DateTime(1994, 05, 03) });
            materialsList.Add(new Material { Title = "Radiate", AuthorId = 2, MaterialId = 5, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 5, Description = "Radiate presentation", PublicationDate = new DateTime(1995, 05, 03) });
            materialsList.Add(new Material { Title = "Hollywood", AuthorId = 3, MaterialId = 6, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 6, Description = "Database of hollywood actors created by Johny Deep Entertaitnment", PublicationDate = new DateTime(1996, 05, 03) });
            materialsList.Add(new Material { Title = "Good pirate", AuthorId = 3, MaterialId = 7, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 7, Description = "Lecture outline, subcject: what can we do to be a good pirate", PublicationDate = new DateTime(1997, 05, 03) });
            materialsList.Add(new Material { Title = "Good pirate pdf", AuthorId = 3, MaterialId = 8, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 1, Description = "Lecture in pdf how to be a good pirate", PublicationDate = new DateTime(1998, 05, 03) });
            materialsList.Add(new Material { Title = "Pirate sounds", AuthorId = 3, MaterialId = 9, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 2, Description = "Ebook with sounds of Johny Deep as a pirate", PublicationDate = new DateTime(1999, 05, 03) });
            materialsList.Add(new Material { Title = "Space tour", AuthorId = 4, MaterialId = 10, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 3, Description = "Space tour video", PublicationDate = new DateTime(1900, 05, 03) });
            materialsList.Add(new Material { Title = "Satelite", AuthorId = 4, MaterialId = 11, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 4, Description = "Create with me small satelite", PublicationDate = new DateTime(1909, 05, 03) });
            materialsList.Add(new Material { Title = "Sun", AuthorId = 4, MaterialId = 12, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 5, Description = "Power Point Presentation about Sun", PublicationDate = new DateTime(1987, 05, 03) });
            materialsList.Add(new Material { Title = "Galactic", AuthorId = 4, MaterialId = 13, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 6, Description = "Database with hole galactic", PublicationDate = new DateTime(1955, 05, 03) });
            materialsList.Add(new Material { Title = "Galactic structure", AuthorId = 4, MaterialId = 14, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 7, Description = "Lecture about galactic structure", PublicationDate = new DateTime(1944, 05, 03) });
            materialsList.Add(new Material { Title = "Cosmos",AuthorId = 4, MaterialId = 15, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 1, Description = "Definitions of cosmos", PublicationDate = new DateTime(1966, 05, 03) });
            materialsList.Add(new Material { Title = "Ebook pirate",AuthorId = 3, MaterialId = 16, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 2, Description = "Johny Deep is reading pirates book", PublicationDate = new DateTime(1972, 05, 03) });
            materialsList.Add(new Material { Title = "Tesla generator",AuthorId = 1, MaterialId = 17, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 3, Description = "Video how to create own tesla generator", PublicationDate = new DateTime(1911, 05, 03) });
            materialsList.Add(new Material { Title = "Radiation",AuthorId = 2, MaterialId = 18, Location = "codecoolʼs library at Ślusarska 9", MaterialTypeId = 4, Description = "Exercices with radiation", PublicationDate = new DateTime(1915, 05, 03) });
            modelBuilder.Entity<Material>().HasData(materialsList);
            //



            ////Admin Credentials
            //CreatePassword("admin", out byte[] passwordHash, out byte[] passwordSalt);
            //var credentials = new CredentialsContainer("admin", "admin")
            //{
            //    CredentialsId = new Guid("ac0b5af3-7368-414a-b40c-ccb9c97adeae"),
            //    PasswordHash = passwordHash,
            //    PasswordSalt = passwordSalt
            //};

            //modelBuilder.Entity<CredentialsContainer>().HasData(credentials);

            //UserAdmin data
            var userAdminList = new List<Admin>();
            userAdminList.Add(new Admin {AdminId = 1, Login = "admin", Password = "admin"});
            modelBuilder.Entity<Admin>().HasData(userAdminList);
        }

        public static void CreatePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            HMACSHA512 hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
