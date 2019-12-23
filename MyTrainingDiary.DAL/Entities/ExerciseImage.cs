using System;
using System.Collections.Generic;
using System.Text;

namespace MyTrainingDiary.DAL.Entities
{
    public class ExerciseImage : EntityBase
    {
        public byte[] ImageData { get; set; } // stringy, cesty k souborum? v pripade telefonu asi spise primo obrazky v DB

        // obrazek patri konkretnimu cviku
        public Guid ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

    }
}
