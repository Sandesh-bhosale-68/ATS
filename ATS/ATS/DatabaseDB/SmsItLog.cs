using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SmsItLog
    {
        public int Id { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MessageText { get; set; }
        public string? HostName { get; set; }
        public string? Winlogin { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? Date { get; set; }
    }
}
