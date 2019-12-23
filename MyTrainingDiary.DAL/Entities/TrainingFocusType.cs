using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    /// <summary>
    /// "Ciselnik", umozni mi snaze zavadet nove typy treninku, ktere budou drzeny v DB na jednom miste.
    /// Kdyby uzivatel typ zadaval rucne a ne z "predpripravenych" typu, byl by v tom dost pravdepodobne neporadek.
    /// </summary>
    public class TrainingFocusType : EntityBase
    {
        public string Name { get; set; } // strength, hypertrophy, endurance, maxStrength, strengthEndurance

        public ICollection<TrainingPlan> TrainingPlans { get; set; } // 1:N
    }
}
