using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    public class Exercise : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ExerciseImage> Images { get; set; } // cvik muze mit vice obrazku
        public ICollection<ExerciseSet> ExerciseSets { get; set; } // cvik muze patrit do vicero serii, protoze se jezdi treba 3-5 serii kazdeho cviku
    }
}
