using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrmisTrainingStatus
    {
        public int Id { get; set; }
        public string? TrainingStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
