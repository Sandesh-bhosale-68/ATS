using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ResignationDemoMaster
    {
        public decimal Id { get; set; }
        public string? Empcode { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public int? ApproveStatus { get; set; }
        public DateTime? Recdate { get; set; }
        public string? Status { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Reason { get; set; }
    }
}
