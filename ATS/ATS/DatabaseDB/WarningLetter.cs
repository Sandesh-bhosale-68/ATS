using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class WarningLetter
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? Types { get; set; }
        public string? Warnings { get; set; }
        public string? Gender { get; set; }
        public string? Location { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public string? EmpCodeLm { get; set; }
        public string? Reason { get; set; }
        public bool? Status { get; set; }
        public string? SystemIp { get; set; }
        public string? UploadBy { get; set; }
        public DateTime? UploadDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? HrwarningDate { get; set; }
    }
}
