using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrTeamDetail
    {
        public int Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? Designation { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
