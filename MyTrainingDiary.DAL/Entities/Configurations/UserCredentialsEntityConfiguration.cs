using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class UserCredentialsEntityConfiguration : IEntityTypeConfiguration<UserCredentials>
    {
        public void Configure(EntityTypeBuilder<UserCredentials> builder)
        {
            builder.ToTable("UserCredentials");
            builder.HasData(
                new UserCredentials
                {
                    Id = new Guid("7bde5330ce7f418b9126c7e48fe26f6e"),
                    UserId = new Guid("f4c90bc5b2804e21875da78596d8b6c4"),
                    Username = "roman.skamene",
                    Password = "1234"

                },
                new UserCredentials
                {
                    Id = new Guid("f34f9cceb9314967b43c2b088ce0a518"),
                    UserId = new Guid("143c36340c9d42e58e3a8eaf7ac0e62b"),
                    Username = "oumen",
                    Password = "12345"
                });
        }
    }
}
