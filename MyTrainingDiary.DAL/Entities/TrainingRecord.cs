using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    public class TrainingRecord : EntityBase
    {
        public DateTime StartDateTime { get; set; } // todo z casovych udaju se spocita delka treninku
        public DateTime FinishDateTime { get; set; }
        public int RestCount { get; set; } // todo pocet pauz, potrebuje ho?
        public TimeSpan TotalRestLength { get; set; }
        public TimeSpan TotalTimeUnderTension { get; set; }

        //public Guid TrainingPlanId { get; set; }
        public TrainingPlan TrainingPlan { get; set; }

        // zaznam z treninku patri konkretnimu uzivateli
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
