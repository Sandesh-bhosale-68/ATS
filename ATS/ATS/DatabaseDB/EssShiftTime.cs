using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssShiftTime
    {
        public int Id { get; set; }
        public string? Shift { get; set; }
        public DateTime? ShiftInTime { get; set; }
        public DateTime? ShiftOutTime { get; set; }
        public int? LocationId { get; set; }
    }
}
