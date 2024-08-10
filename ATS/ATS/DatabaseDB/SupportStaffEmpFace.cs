using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SupportStaffEmpFace
    {
        public string EmpCode { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public string? Department { get; set; }
        public string? CurrentDesignation { get; set; }
        public string? CurrentLocation { get; set; }
        public string? Gender { get; set; }
        public DateTime? Doj { get; set; }
    }
}
