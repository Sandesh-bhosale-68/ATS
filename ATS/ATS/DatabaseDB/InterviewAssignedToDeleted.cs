using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class InterviewAssignedToDeleted
    {
        public long Id { get; set; }
        public decimal? MasterId { get; set; }
        public string? AssignedTo { get; set; }
        public int? Round { get; set; }
        public string? AssignedBy { get; set; }
        public string? InterviewStatus { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RecDate { get; set; }
        public string? Process { get; set; }
        public string? RejectedReason { get; set; }
    }
}
