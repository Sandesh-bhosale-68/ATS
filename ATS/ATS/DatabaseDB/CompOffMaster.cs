using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class CompOffMaster
    {
        public decimal Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? CompOffDate { get; set; }
        public DateTime? SancDate { get; set; }
        public byte? SancStatus { get; set; }
        public string? AdjDate { get; set; }
        public string? Remarks { get; set; }
        public string? SupId { get; set; }
        public string? SupComment { get; set; }
        public DateTime? ApplyDate { get; set; }
    }
}
