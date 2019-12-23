using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class ExerciseSetEntityConfiguration : IEntityTypeConfiguration<ExerciseSet>
    {
        public void Configure(EntityTypeBuilder<ExerciseSet> builder)
        {
            builder.ToTable("ExerciseSets");
            builder.HasData(
                //prvni cvik 3 serie klik
                new ExerciseSet
                {
                    Id = new Guid("77de7d497ee249da960b20aa1e3e6e55"),
                    ExerciseId = new Guid("5ad47bf70300462aa547dd30691e18d3"),
                    Load = 0,
                    Repetitions = 15,
                    RestTime = new TimeSpan(0, 3, 0),
                    TrainingPlanId = new Guid("8565b47995c947f6af2977fd2254fa2a")
                },
                new ExerciseSet
                {
                    Id = new Guid("dac5960249b1442283cbf0b4f01ece93"),
                    ExerciseId = new Guid("5ad47bf70300462aa547dd30691e18d3"),
                    Load = 5,
                    Repetitions = 10,
                    RestTime = new TimeSpan(0, 3, 0),
                    TrainingPlanId = new Guid("8565b47995c947f6af2977fd2254fa2a"),
                },
                new ExerciseSet
                {
                    Id = new Guid("d93da7012f864de3bc4fd1d145f6fc6e"),
                    ExerciseId = new Guid("5ad47bf70300462aa547dd30691e18d3"),
                    Load = 10,
                    Repetitions = 15,
                    RestTime = new TimeSpan(0, 3, 0),
                    TrainingPlanId = new Guid("8565b47995c947f6af2977fd2254fa2a")
                },
                // dalsi cvik 3 serie drep
                new ExerciseSet
                {
                    Id = new Guid("4c9f0c3f21bc4611aa7f547e0e89a602"),
                    ExerciseId = new Guid("1f38c38684a048c098a501a020ba9051"),
                    Load = 20,
                    Repetitions = 15,
                    RestTime = new TimeSpan(0, 3, 0),
                    TrainingPlanId = new Guid("8565b47995c947f6af2977fd2254fa2a")
                },
                new ExerciseSet
                {
                    Id = new Guid("d2ab2bf4d4284fccb84249d1670fbe19"),
                    ExerciseId = new Guid("1f38c38684a048c098a501a020ba9051"),
                    Load = 50,
                    Repetitions = 12,
                    RestTime = new TimeSpan(0, 3, 0),
                    TrainingPlanId = new Guid("8565b47995c947f6af2977fd2254fa2a")
                },
                new ExerciseSet
                {
                    Id = new Guid("40cd147416fc414cb9c57c0ab4a0aed8"),
                    ExerciseId = new Guid("1f38c38684a048c098a501a020ba9051"),
                    Load = 70,
                    Repetitions = 8,
                    RestTime = new TimeSpan(0, 3, 0),
                    TrainingPlanId = new Guid("8565b47995c947f6af2977fd2254fa2a")
                });
        }
    }
}
