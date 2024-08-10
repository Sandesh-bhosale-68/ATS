using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmailVerifyDetail
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? WhenEntered { get; set; }
    }
}
