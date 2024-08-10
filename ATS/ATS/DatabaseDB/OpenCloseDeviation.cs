using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class OpenCloseDeviation
    {
        public int Id { get; set; }
        public DateTime? DeviationDate { get; set; }
        public string? Location { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
