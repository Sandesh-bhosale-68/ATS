using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SmsItLogin
    {
        public int Id { get; set; }
        public string? EmployeeCode { get; set; }
        public string? LocationAccess { get; set; }
        public string? Name { get; set; }
        public string? MobileNo { get; set; }
        public string? Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
