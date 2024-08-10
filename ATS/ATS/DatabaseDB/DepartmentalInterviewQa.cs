using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DepartmentalInterviewQa
    {
        public long Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? CompetencyDescription { get; set; }
        public string? Designation { get; set; }
        public string? SubDeptName { get; set; }
    }
}
