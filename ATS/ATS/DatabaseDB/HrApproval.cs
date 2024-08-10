using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrApproval
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? Type { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
