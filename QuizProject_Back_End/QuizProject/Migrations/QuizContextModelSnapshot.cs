﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizProject.Models;

namespace QuizProject.Migrations
{
    [DbContext(typeof(QuizContext))]
    partial class QuizContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "a83cb833-4019-510d-9f17-a9d0b83540ee",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "d82cb833-4019-410d-9f17-a9d0b83247ee",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed6a7ffc-d690-4a46-b6ae-72cae474c830",
                            Email = "monstercattop@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MONSTERCATTOP@GMAIL.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEIEtR1ucmbbJMJHGwVSBApybXYC3LRQpi12+zl4E+7gF165IcUlwRLrLxeM9JFSMVQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd74b806-67be-43e9-9344-17e4ecb94334",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "d82cb833-4019-410d-9f17-a9d0b83247ee",
                            RoleId = "a83cb833-4019-510d-9f17-a9d0b83540ee"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QuizProject.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ans")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Ans = "Private",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 102,
                            Ans = "Private Protected",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 103,
                            Ans = "Protected",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 104,
                            Ans = "Internal",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 105,
                            Ans = "Public",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 106,
                            Ans = "Bool",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 107,
                            Ans = "Integer",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 108,
                            Ans = "Class",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 109,
                            Ans = "Structure",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 110,
                            Ans = "Char",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 111,
                            Ans = "null",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 112,
                            Ans = "ref",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 113,
                            Ans = "public",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 114,
                            Ans = "static",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 115,
                            Ans = "<T>",
                            QuestionId = 3
                        });
                });

            modelBuilder.Entity("QuizProject.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CorrectAnswer = "Private",
                            Quest = "What access modifier make component available only within it's class of struct?",
                            TestId = 1
                        },
                        new
                        {
                            Id = 2,
                            CorrectAnswer = "Class",
                            Quest = "What of these types is Referense type?",
                            TestId = 1
                        },
                        new
                        {
                            Id = 3,
                            CorrectAnswer = "ref",
                            Quest = "What modifier can pass parameters by reference?",
                            TestId = 1
                        });
                });

            modelBuilder.Entity("QuizProject.Models.QuizUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuizUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "Administrator",
                            Score = 0
                        });
                });

            modelBuilder.Entity("QuizProject.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            TestId = 1,
                            Name = "C# Beginers Test"
                        });
                });

            modelBuilder.Entity("QuizProject.Models.TestStatistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AvgFirstTryResult")
                        .HasColumnType("int");

                    b.Property<int>("AvgTryCount")
                        .HasColumnType("int");

                    b.Property<int?>("BestResult")
                        .HasColumnType("int");

                    b.Property<string>("BestResultUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BestTimeUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountOfAllTries")
                        .HasColumnType("int");

                    b.Property<int?>("MinTries")
                        .HasColumnType("int");

                    b.Property<string>("MinTriesUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId")
                        .IsUnique();

                    b.ToTable("Statistics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvgFirstTryResult = 0,
                            AvgTryCount = 0,
                            BestResult = 0,
                            CountOfAllTries = 0,
                            MinTries = 0,
                            TestId = 1
                        });
                });

            modelBuilder.Entity("QuizProject.Models.UserCreatedTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuizUserId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizUserId");

                    b.HasIndex("TestId");

                    b.ToTable("CreatedTests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QuizUserId = 1,
                            TestId = 1
                        });
                });

            modelBuilder.Entity("QuizProject.Models.UserStatistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuizUserId")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TriesCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizUserId");

                    b.ToTable("UserStatistic");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizProject.Models.Answer", b =>
                {
                    b.HasOne("QuizProject.Models.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizProject.Models.Question", b =>
                {
                    b.HasOne("QuizProject.Models.Test", null)
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizProject.Models.TestStatistic", b =>
                {
                    b.HasOne("QuizProject.Models.Test", null)
                        .WithOne("TestStatistic")
                        .HasForeignKey("QuizProject.Models.TestStatistic", "TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizProject.Models.UserCreatedTest", b =>
                {
                    b.HasOne("QuizProject.Models.QuizUser", null)
                        .WithMany("CreatedTests")
                        .HasForeignKey("QuizUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizProject.Models.Test", null)
                        .WithMany("UserCreatedTest")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizProject.Models.UserStatistic", b =>
                {
                    b.HasOne("QuizProject.Models.QuizUser", null)
                        .WithMany("UserTestCount")
                        .HasForeignKey("QuizUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
