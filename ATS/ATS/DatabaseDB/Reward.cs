using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Reward
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? EmpCode { get; set; }
        public int? AppraisalTypeId { get; set; }
        public int? Kra { get; set; }
        public double? CurrentCtc { get; set; }
        public string? RevisedCtc { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? CurrentDesignation { get; set; }
        public string? RevisedDesignation { get; set; }
        public bool? Status { get; set; }
        public string? FyYear { get; set; }
        public double? Bonus { get; set; }
        public string? UploadBy { get; set; }
        public DateTime? UploadDate { get; set; }
        public string? PercentageHike { get; set; }

        public virtual AppraisalList? AppraisalType { get; set; }
    }
}
