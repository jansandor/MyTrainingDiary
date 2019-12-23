using Microsoft.EntityFrameworkCore;
using MyTrainingDiary.DAL.Entities;
using MyTrainingDiary.DAL.Entities.Configurations;
using System;

namespace MyTrainingDiary.DAL
{
    public class MtdAppDbContext : DbContext
    {
        private string _dbPath;

        public MtdAppDbContext(string dbPath) : base()
        {
            _dbPath = dbPath;
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Melo by slapat podle konvenci EF (spravne napsane domain classes)

            //modelBuilder.Entity<User>()
            //    .HasKey(u => u.Id);
            //modelBuilder.Entity<User>()
            //    .HasOne<UserCredentials>(u => u.UserCredentials)
            //    .WithOne(uc => uc.User)
            //    .HasForeignKey<UserCredentials>(uc => uc.UserId);

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserCredentialsEntityConfiguration());

            modelBuilder.ApplyConfiguration(new TrainingFocusTypeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingTypeEntityConfiguration());

            modelBuilder.ApplyConfiguration(new ExerciseEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseSetEntityConfiguration());

            modelBuilder.ApplyConfiguration(new TrainingPlanEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingRecordEntityConfiguration());
        }

        public DbSet<Exercise> Exercises { get; set; }
        // public DbSet<ExerciseImage> ExerciseImages { get; set; }
        public DbSet<ExerciseSet> ExerciseSets { get; set; }
        public DbSet<TrainingFocusType> TrainingFocusTypes { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<TrainingRecord> TrainingRecords { get; set; }
        public DbSet<TrainingType> TrainingTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCredentials> UserCredentials { get; set; }
    }
}
