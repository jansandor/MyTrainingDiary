using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class TrainingTypeEntityConfiguration : IEntityTypeConfiguration<TrainingType>
    {
        public void Configure(EntityTypeBuilder<TrainingType> builder)
        {
            builder.ToTable("TrainingTypes");
            builder.HasData(
                new TrainingType()
                {
                    Id = new Guid("28126bf54c1743fdad9864aa07550f6b"),
                    Name = "Fullbody"
                },
                new TrainingType()
                {
                    Id = new Guid("b46d1360654e4a2bbc603235c9dff218"),
                    Name = "Mixed"
                });
        }
    }
}