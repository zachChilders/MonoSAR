﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoSAR.Models.Training
{
    public class TrainingOccurrenceInsert
    {
        public Int32 TrainingID { get; set; }

        public DateTime TrainingDate { get; set; }

        public Int32 InstructorMemberID { get; set; }

        public IEnumerable<Training.TrainingOccurrenceParticipationInsert> Participants { get; set; }

        public IEnumerable<Int32> Instructors { get; set; }

    }
}
