using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class JobPosting
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? EmailId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
