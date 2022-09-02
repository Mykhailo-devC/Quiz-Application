﻿using Microsoft.EntityFrameworkCore;
using QuizProject.Models.ModelConfiguration;

namespace QuizProject.Models
{
    public class QuizContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<UserTestCount> UserTests { get; set; }
        public DbSet<UserCreatedTest> CreatedTests { get; set; }
        public QuizContext(DbContextOptions<QuizContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TestConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new CreatedTestConfiguration());
            //modelBuilder.Entity<User>(u => { u.HasMany(e => e.CreatedTests).WithOne(e => e.User).HasForeignKey(e => e.UserId); });
            //modelBuilder.Entity<User>().Property(u => u.CreatedTests).IsRequired(false);
            /*modelBuilder.Entity<Test>(t =>
            {
                t.HasOne(e => e.UserCreatedTest).WithOne(e => e.Test).HasForeignKey();
            });*/
            /*modelBuilder.Entity<Test>(e => {
                e.HasMany(q => q.Questions).WithOne(q => q.Test).HasForeignKey(q => q.TestId);
                e.HasKey(q => q.TestId);
            });
            modelBuilder.Entity<Question>(e => {
                e.HasOne(q => q.Test).WithMany(q => q.Questions).HasForeignKey(q => q.TestId).HasConstraintName("FK_Questions_Tests");
                e.HasKey(q => q.Id);
            });*/
        }
    }
}