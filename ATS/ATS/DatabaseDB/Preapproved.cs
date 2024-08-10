using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Preapproved
    {
        public int Sno { get; set; }
        public string? CardNo { get; set; }
        public string? EmpCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? RequestLeaveType { get; set; }
        public int? SanctionLeaveType { get; set; }
        public DateTime? SanctionDate { get; set; }
        public string? SanctionBy { get; set; }
        public string? Status { get; set; }
        public decimal? RequestId { get; set; }
    }
}
