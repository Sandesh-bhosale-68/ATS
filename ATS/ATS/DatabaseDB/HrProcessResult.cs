using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrProcessResult
    {
        public long Id { get; set; }
        public long? MasterId { get; set; }
        public string? MobileNo { get; set; }
        public int? Answer1 { get; set; }
        public int? Answer2 { get; set; }
        public int? Answer3 { get; set; }
        public int? Answer4 { get; set; }
        public int? Answer5 { get; set; }
        public int? Answer6 { get; set; }
        public int? Answer7 { get; set; }
        public int? Answer8 { get; set; }
        public int? Answer9 { get; set; }
        public int? Answer10 { get; set; }
        public string? Round1 { get; set; }
        public string? Round2 { get; set; }
        public DateTime? RecDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
