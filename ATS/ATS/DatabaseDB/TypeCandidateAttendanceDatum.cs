using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TypeCandidateAttendanceDatum
    {
        public decimal? MasterId { get; set; }
        public string? CandidateName { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public string? Attendance { get; set; }
        public string? Remark { get; set; }
        public bool? Status { get; set; }
    }
}
