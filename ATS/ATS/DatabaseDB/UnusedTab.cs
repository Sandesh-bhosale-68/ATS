using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UnusedTab
    {
        public string? TabName { get; set; }
        public DateTime? OldestDate { get; set; }
        public DateTime? LatestDate { get; set; }
        public int? RowCnt { get; set; }
        public string? ColName { get; set; }
    }
}
