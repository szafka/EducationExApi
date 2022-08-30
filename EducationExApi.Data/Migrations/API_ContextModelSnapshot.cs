﻿// <auto-generated />
using System;
using EducationExApi.Data.Model.API_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EducationExApi.Data.Migrations
{
    [DbContext(typeof(API_Context))]
    partial class API_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Description = "Master of quantum physics",
                            Name = "Albert Einstein"
                        },
                        new
                        {
                            AuthorId = 2,
                            Description = "Master of Chemistry",
                            Name = "Maria Skłodowska-Curie"
                        },
                        new
                        {
                            AuthorId = 3,
                            Description = "Actor, pirate",
                            Name = "Johny Deep"
                        },
                        new
                        {
                            AuthorId = 4,
                            Description = "Galactic rider of yellow magnetic star",
                            Name = "Szafarz"
                        });
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MaterialTypeId");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            MaterialId = 1,
                            AuthorId = 1,
                            Description = "Structure of atom",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 1,
                            PublicationDate = new DateTime(1991, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Structur of atom"
                        },
                        new
                        {
                            MaterialId = 2,
                            AuthorId = 1,
                            Description = "Listen exploding atom sounds",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 2,
                            PublicationDate = new DateTime(1992, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Atom sounds"
                        },
                        new
                        {
                            MaterialId = 3,
                            AuthorId = 2,
                            Description = "Video-tutorial how to make taste drink",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 3,
                            PublicationDate = new DateTime(1993, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Taste drink"
                        },
                        new
                        {
                            MaterialId = 4,
                            AuthorId = 2,
                            Description = "Excersice how to check skin structure",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 4,
                            PublicationDate = new DateTime(1994, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Skin structure"
                        },
                        new
                        {
                            MaterialId = 5,
                            AuthorId = 2,
                            Description = "Radiate presentation",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 5,
                            PublicationDate = new DateTime(1995, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Radiate"
                        },
                        new
                        {
                            MaterialId = 6,
                            AuthorId = 3,
                            Description = "Database of hollywood actors created by Johny Deep Entertaitnment",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 6,
                            PublicationDate = new DateTime(1996, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hollywood"
                        },
                        new
                        {
                            MaterialId = 7,
                            AuthorId = 3,
                            Description = "Lecture outline, subcject: what can we do to be a good pirate",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 7,
                            PublicationDate = new DateTime(1997, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Good pirate"
                        },
                        new
                        {
                            MaterialId = 8,
                            AuthorId = 3,
                            Description = "Lecture in pdf how to be a good pirate",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 1,
                            PublicationDate = new DateTime(1998, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Good pirate pdf"
                        },
                        new
                        {
                            MaterialId = 9,
                            AuthorId = 3,
                            Description = "Ebook with sounds of Johny Deep as a pirate",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 2,
                            PublicationDate = new DateTime(1999, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pirate sounds"
                        },
                        new
                        {
                            MaterialId = 10,
                            AuthorId = 4,
                            Description = "Space tour video",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 3,
                            PublicationDate = new DateTime(1900, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Space tour"
                        },
                        new
                        {
                            MaterialId = 11,
                            AuthorId = 4,
                            Description = "Create with me small satelite",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 4,
                            PublicationDate = new DateTime(1909, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Satelite"
                        },
                        new
                        {
                            MaterialId = 12,
                            AuthorId = 4,
                            Description = "Power Point Presentation about Sun",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 5,
                            PublicationDate = new DateTime(1987, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sun"
                        },
                        new
                        {
                            MaterialId = 13,
                            AuthorId = 4,
                            Description = "Database with hole galactic",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 6,
                            PublicationDate = new DateTime(1955, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Galactic"
                        },
                        new
                        {
                            MaterialId = 14,
                            AuthorId = 4,
                            Description = "Lecture about galactic structure",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 7,
                            PublicationDate = new DateTime(1944, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Galactic structure"
                        },
                        new
                        {
                            MaterialId = 15,
                            AuthorId = 4,
                            Description = "Definitions of cosmos",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 1,
                            PublicationDate = new DateTime(1966, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Cosmos"
                        },
                        new
                        {
                            MaterialId = 16,
                            AuthorId = 3,
                            Description = "Johny Deep is reading pirates book",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 2,
                            PublicationDate = new DateTime(1972, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ebook pirate"
                        },
                        new
                        {
                            MaterialId = 17,
                            AuthorId = 1,
                            Description = "Video how to create own tesla generator",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 3,
                            PublicationDate = new DateTime(1911, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tesla generator"
                        },
                        new
                        {
                            MaterialId = 18,
                            AuthorId = 2,
                            Description = "Exercices with radiation",
                            Location = "codecoolʼs library at Ślusarska 9",
                            MaterialTypeId = 4,
                            PublicationDate = new DateTime(1915, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Radiation"
                        });
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.MaterialType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Outline of definition in .pdf type file",
                            Type = "Pdf file"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ebook-materil with lectures read by the author",
                            Type = "Ebook"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Video-tutorial with developed step-by-step examples",
                            Type = "Video"
                        },
                        new
                        {
                            Id = 4,
                            Description = "WorkBook with definitions, samples, excersices, answers",
                            Type = "WorkBook"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Power Point presentation material",
                            Type = "Presentation"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Database file with seeder",
                            Type = "Database file script"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Lecture outline with materials from lecture",
                            Type = "Lecture outline"
                        });
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("AdminId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("EducationExApi.Data.Model.UsersModel.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            Login = "admin",
                            Password = "admin"
                        });
                });

            modelBuilder.Entity("EducationExApi.Data.Model.UsersModel.CredentialsContainer", b =>
                {
                    b.Property<Guid>("CredentialsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CredentialsId");

                    b.ToTable("CredentialsContainers");
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.Material", b =>
                {
                    b.HasOne("EducationExApi.Data.Model.CodecoolDataModel.Author", "Author")
                        .WithMany("Materials")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationExApi.Data.Model.CodecoolDataModel.MaterialType", "MaterialType")
                        .WithMany("Materials")
                        .HasForeignKey("MaterialTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("MaterialType");
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.Review", b =>
                {
                    b.HasOne("EducationExApi.Data.Model.UsersModel.Admin", null)
                        .WithMany("Reviews")
                        .HasForeignKey("AdminId");

                    b.HasOne("EducationExApi.Data.Model.CodecoolDataModel.Material", "Material")
                        .WithMany("Reviews")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.Author", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.Material", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("EducationExApi.Data.Model.CodecoolDataModel.MaterialType", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("EducationExApi.Data.Model.UsersModel.Admin", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
