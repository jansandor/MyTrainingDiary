using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class TrainingPlanEntityConfiguration : IEntityTypeConfiguration<TrainingPlan>
    {
        public void Configure(EntityTypeBuilder<TrainingPlan> builder)
        {
            builder.ToTable("TrainingPlans");
            builder.HasData(
                new TrainingPlan
                {
                    Id = new Guid("8565b47995c947f6af2977fd2254fa2a"),
                    Name = "Push ups & Squats",
                    UserId = new Guid("f4c90bc5b2804e21875da78596d8b6c4"), // roman skamene
                    TrainingFocusTypeId = new Guid("1a2230a3d1224d30aae26d1bddf350aa"), // strength
                    TrainingTypeId = new Guid("b46d1360654e4a2bbc603235c9dff218"), // mixed
                    TrainingRecordId = null,
                    /*ExerciseSets = new List<ExerciseSet>()
                    {
                        new ExerciseSet
                        {
                            Id = new Guid("77de7d497ee249da960b20aa1e3e6e55")
                        },
                        new ExerciseSet
                        {
                            Id = new Guid("dac5960249b1442283cbf0b4f01ece93")
                        },
                        new ExerciseSet
                        {
                            Id = new Guid("d93da7012f864de3bc4fd1d145f6fc6e")
                        },
                        new ExerciseSet
                        {
                            Id = new Guid("4c9f0c3f21bc4611aa7f547e0e89a602")
                        },
                        new ExerciseSet
                        {
                            Id = new Guid("d2ab2bf4d4284fccb84249d1670fbe19")
                        },
                        new ExerciseSet
                        {
                            Id = new Guid("40cd147416fc414cb9c57c0ab4a0aed8")
                        }
                    }*/
                });
        }
    }
}
