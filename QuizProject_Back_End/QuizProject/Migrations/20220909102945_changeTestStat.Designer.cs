﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizProject.Models;

namespace QuizProject.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20220909102945_changeTestStat")]
    partial class changeTestStat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            BestResult = 0,
                            CountOfAllTries = 0,
                            MinTries = 0,
                            TestId = 1
                        });
                });

            modelBuilder.Entity("QuizProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "Admin",
                            Password = "admin",
                            Score = 0
                        });
                });

            modelBuilder.Entity("QuizProject.Models.UserCreatedTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("CreatedTests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TestId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("QuizProject.Models.UserTestCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("TestTried")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TriesCount")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTests");
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
                    b.HasOne("QuizProject.Models.Test", null)
                        .WithMany("UserCreatedTest")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizProject.Models.User", null)
                        .WithMany("CreatedTests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizProject.Models.UserTestCount", b =>
                {
                    b.HasOne("QuizProject.Models.User", null)
                        .WithMany("UserTestCount")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
