using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class AttendanceType
    {
        public int AttenadanceTypeId { get; set; }
        public string? AttendanceType1 { get; set; }
        public string? Color { get; set; }
        public string? ColorCode { get; set; }
        public bool? Status { get; set; }
    }
}
