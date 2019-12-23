using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    public class ExerciseSet : EntityBase
    {
        public int Load { get; set; } // todo struktura/trida hodnota + jednotka? zatim pocitam s vahou v kg
        public int Repetitions { get; set; }

        public TimeSpan TimeUnderTension { get; set; } // kazda serie je provadena nejakou dobu (souvis s intenzitou treninku)
        public TimeSpan RestTime { get; set; } // po kazde serii je pauza, proto bych ji ponechal v ramci dane serie, at muze byt ruzna

        // serie se tyka jedineho cviku
        public Guid ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        // serie patri jednomu planu
        public Guid TrainingPlanId { get; set; } 
        public TrainingPlan TrainingPlan { get; set; }
    }
}
