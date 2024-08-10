using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class InterviewerEmailDetail
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmailId { get; set; }
        public bool? IsActive { get; set; }
    }
}
