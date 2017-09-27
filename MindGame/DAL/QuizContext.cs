using MindGame.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MindGame.DAL
{
    public class QuizContext : DbContext
    {
        public QuizContext() : base("MindGame")
        {
        }

        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<QuizAnalyze> QuizAnalyzes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // modelBuilder.Entity<Quiz>().HasMany(x => x.QuizAnalyze);
            modelBuilder.Entity<Quiz>().HasMany(x => x.QuizAnalyze).
                 WithRequired(x => x.Quiz).HasForeignKey(x=>x.QuizID);
        }
    }
}