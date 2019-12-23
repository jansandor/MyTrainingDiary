using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    public class TrainingPlan : EntityBase
    {
        public string Name { get; set; }

        public ICollection<ExerciseSet> ExerciseSets { get; set; } // ma vice serii (vybranych) cvikuu

        public Guid TrainingTypeId { get; set; }
        public TrainingType TrainingType { get; set; } // pull, push, mobility, skill, fullbody, cardio?, mixed [push-pull], flexibility, joga (whatever)

        public Guid TrainingFocusTypeId { get; set; }
        public TrainingFocusType TrainingFocusType { get; set; } // strength, hypertrophy, endurance, maxStrength, strengthEndurance
        
        // TODO plan ma vice zaznamu? prece jen muzu odcvicit treba 5 treninku podle daneho planu

        public Guid? TrainingRecordId { get; set; } // podle planu je odcvicen nektery trenink, z ktereho je pak zaznam, potom se id prida
        public TrainingRecord TrainingRecord { get; set; }

        // treninkovy plan patri konkretnimu uzivateli
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
