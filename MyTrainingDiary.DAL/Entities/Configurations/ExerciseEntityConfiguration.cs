using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities.Configurations
{
    public class ExerciseEntityConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercises");
            builder.HasData(
                new Exercise
                {
                    Id = new Guid("5ad47bf70300462aa547dd30691e18d3"),
                    Name = "Push up",
                    Description =
                        "Push-up is an exercise done laying with face, palms and toes facing down, keeping legs and back straight, extending arms straight to push body up and back down again. An example of a push-up is a great exercise that works the chest, shoulder and arm muscles."

                },
                new Exercise
                {
                    Id = new Guid("1f38c38684a048c098a501a020ba9051"),
                    Name = "Squat",
                    Description =
                        "A squat is a strength exercise in which the trainee lowers their hips from a standing position and then stands back up. During the descent of a squat, the hip and knee joints flex while the ankle joint dorsiflexes; conversely the hip and knee joints extend and the ankle joint plantarflexes when standing up."

                },
                new Exercise
                {
                    Id = new Guid("e4eed330a4434631b67407be5dc9d743"),
                    Name = "Pull up",
                    Description =
                        "A pull-up is an upper-body strength exercise. The pull-up is a closed-chain movement where the body is suspended by the hands and pulls up. As this happens, the elbows flex and the shoulders adduct and extend to bring the elbows to the torso.",

                },
                new Exercise
                {
                    Id = new Guid("d8a76b4cedcd4e189141aad374b7ef45"),
                    Name = "Dip",
                    Description =
                        "A dip is an upper-body strength exercise. Narrow, shoulder-width dips primarily train the triceps, with major synergists being the anterior deltoid, the pectoralis muscles (sternal, clavicular, and minor), and the rhomboid muscles of the back (in that order)."

                });
        }
    }
}
