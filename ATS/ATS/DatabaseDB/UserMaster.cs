using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UserMaster
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? RepeatPassword { get; set; }
        public string? EmpCode { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? WhenEntered { get; set; }
        public int RoleId { get; set; }
    }
}
