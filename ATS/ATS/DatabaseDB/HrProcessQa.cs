using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrProcessQa
    {
        public long Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? CompetencyDescription { get; set; }
        public string? Designation { get; set; }
    }
}
