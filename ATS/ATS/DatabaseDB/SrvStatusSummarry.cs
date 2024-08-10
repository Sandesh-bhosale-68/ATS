using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvStatusSummarry
    {
        public long SrvId { get; set; }
        public string? SrvName { get; set; }
        public int? TotalParticipants { get; set; }
        public int? Participated { get; set; }
        public int? Age { get; set; }
    }
}
