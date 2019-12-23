using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class TrainingRecordEntityConfiguration : IEntityTypeConfiguration<TrainingRecord>
    {
        public void Configure(EntityTypeBuilder<TrainingRecord> builder)
        {
            builder.ToTable("TrainingRecords");
            builder.HasData(new List<TrainingRecord>()
            {
                new TrainingRecord
                {
                    Id = new Guid("f66324ac7dec4c3fb3464d3463faa774"),
                    UserId = new Guid("f4c90bc5b2804e21875da78596d8b6c4"),
                    StartDateTime = new DateTime(2018,12,20,17,06,00),
                    FinishDateTime = new DateTime(2018,12,20,19,08,00),
                    RestCount = 7,
                    //TrainingPlanId = new Guid("8565b47995c947f6af2977fd2254fa2a"),
                    TotalRestLength = TimeSpan.FromMinutes(21),
                    TotalTimeUnderTension = TimeSpan.FromMinutes(9)
                }
            });
        }
    }
}
