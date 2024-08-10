using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RelievingLetterLog
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? Gender { get; set; }
        public string? Location { get; set; }
        public DateTime? Doj { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public DateTime? LeavingDate { get; set; }
        public string? SystemName { get; set; }
        public string? UploadBy { get; set; }
        public DateTime? UploadDate { get; set; }
    }
}
