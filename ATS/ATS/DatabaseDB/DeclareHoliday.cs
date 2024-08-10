using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DeclareHoliday
    {
        public int Id { get; set; }
        public DateTime LeaveDate { get; set; }
        public string LeaveTitle { get; set; } = null!;
        public string? LeaveType { get; set; }
        public string? Location { get; set; }
    }
}
