using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class AttendanceStatusType
    {
        public int Id { get; set; }
        public string? StatusCode { get; set; }
        public string? AttendanceStatus { get; set; }
        public string? LeavesEntitled { get; set; }
        public string? AvailableLeaves { get; set; }
        public string? MonthlyLeaves { get; set; }
    }
}
