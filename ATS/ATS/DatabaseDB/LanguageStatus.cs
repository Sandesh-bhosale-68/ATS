using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class LanguageStatus
    {
        public long Id { get; set; }
        public long? MasterId { get; set; }
        public string? MobileNo { get; set; }
        public string? Language { get; set; }
        public bool? Read { get; set; }
        public bool? Write { get; set; }
        public bool? Speak { get; set; }
        public DateTime? RecDate { get; set; }
    }
}
