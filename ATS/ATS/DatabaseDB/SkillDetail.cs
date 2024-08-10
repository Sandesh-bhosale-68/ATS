using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SkillDetail
    {
        public long Id { get; set; }
        public long? MasterId { get; set; }
        public string? MobileNo { get; set; }
        public string? Certification { get; set; }
        public string? YearOfPassing { get; set; }
        public string? Percentage { get; set; }
        public DateTime? RecDate { get; set; }
    }
}
