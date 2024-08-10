using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrreportUser
    {
        public int Id { get; set; }
        public string? EmpName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? OldPassword { get; set; }
        public string? Role { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
