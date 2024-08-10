using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TrainingHistory
    {
        public int Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? CName { get; set; }
        public string? BatchId { get; set; }
        public string? TrainerEbl { get; set; }
        public DateTime? BatchAssignedStrtDt { get; set; }
        public DateTime? BatchAssignedEndDt { get; set; }
        public string? BatchAssignedBy { get; set; }
        public string? BatchUnassignedBy { get; set; }
        public string? CStatus { get; set; }
    }
}
