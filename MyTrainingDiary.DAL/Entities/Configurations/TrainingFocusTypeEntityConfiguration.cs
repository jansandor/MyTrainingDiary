using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class TrainingFocusTypeEntityConfiguration : IEntityTypeConfiguration<TrainingFocusType>
    {
        public void Configure(EntityTypeBuilder<TrainingFocusType> builder)
        {
            builder.ToTable("TrainingFocusTypes");
            builder.HasData(
                new TrainingFocusType()
                {
                    Id = new Guid("6f2b42c748594bf7b0cfaee6ec09cf0e"),
                    Name = "Hypertrophy"
                },
                new TrainingFocusType()
                {
                    Id = new Guid("1a2230a3d1224d30aae26d1bddf350aa"),
                    Name = "Strength"
                });
        }
    }
}