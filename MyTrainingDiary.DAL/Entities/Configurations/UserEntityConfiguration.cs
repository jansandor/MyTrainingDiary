using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasData(
                new User
                {
                    Id = new Guid("f4c90bc5b2804e21875da78596d8b6c4"),
                    Age = 27,
                    Email = "roman.skamene@email.cz",
                    FirstName = "Roman",
                    Surname = "Skamene",
                    Weight = 97
                },
                new User
                {
                    Id = new Guid("143c36340c9d42e58e3a8eaf7ac0e62b"),
                    Age = 25,
                    Email = "oumen@email.cz",
                    FirstName = "Jarda",
                    Surname = "Oumén",
                    Weight = 75
                });
        }
    }
}
