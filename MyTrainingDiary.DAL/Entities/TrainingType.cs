using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    /// <summary>
    /// "Ciselnik", umozni mi snaze zavadet nove typy treninku, ktere budou drzeny v DB na jednom miste.
    /// Kdyby uzivatel typ zadaval rucne a ne z "predpripravenych" typu, byl by v tom dost pravdepodobne neporadek.
    /// </summary>
    public class TrainingType : EntityBase
    {
        public string Name { get; set; } // pull, push, mobility, skill, fullbody, cardio?, mixed [push-pull], flexibility, joga (whatever else)

        // 1:M vice treninkovych planu muze byt jedineho (stejneho) typu (napr. 3 fullbody plany)
        public ICollection<TrainingPlan> TrainingPlans { get; set; } 
    }
}
