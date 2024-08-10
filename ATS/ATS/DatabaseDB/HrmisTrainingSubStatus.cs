using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrmisTrainingSubStatus
    {
        public int Id { get; set; }
        public string? TrainingSubStatus { get; set; }
        public int? TrainingStatusId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
