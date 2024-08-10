using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class LoginLog
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? HostName { get; set; }
        public int? LocationId { get; set; }
        public DateTime? Logindate { get; set; }
    }
}
