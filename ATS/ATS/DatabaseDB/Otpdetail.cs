using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Otpdetail
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public long? Mobile { get; set; }
        public string? Otp { get; set; }
        public DateTime? SentTime { get; set; }
        public DateTime? WhenEntered { get; set; }
        public DateTime? WhenModified { get; set; }
        public string? EmailOtp { get; set; }
    }
}
