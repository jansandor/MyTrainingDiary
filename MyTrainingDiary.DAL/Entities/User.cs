using MyTrainingDiary.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int? Weight { get; set; } // vaha nemusi byt zadana
        public int? Age { get; set; } // vek nemusi byt zadany

        public UserCredentials UserCredentials { get; set; } // uzivatel ma jedny udaje
        public ICollection<TrainingPlan> TrainingPlans { get; set; } // uzivatel ma treninkove plany
        public ICollection<TrainingRecord> TrainingRecords { get; set; } // uzivatel ma zaznamy z treninku

        // todo profile pic(s)
    }
}
