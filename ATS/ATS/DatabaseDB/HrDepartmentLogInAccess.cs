using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrDepartmentLogInAccess
    {
        public long Id { get; set; }
        public string? EmpCode { get; set; }
        public string? Department { get; set; }
        public string? CurrentDesignation { get; set; }
        public string? CurrentMobile { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RecDate { get; set; }
    }
}
