using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class LeaveTrackerLog
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? MonthYear { get; set; }
        public decimal? TotalLeaveBalance { get; set; }
        public decimal? AvailedLeaveBalance { get; set; }
        public decimal? CurrentLeaveBalance { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? OldCurrentLeaveBalance { get; set; }
    }
}
