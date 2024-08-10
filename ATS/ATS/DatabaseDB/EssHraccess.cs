using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssHraccess
    {
        public int Id { get; set; }
        public string? EmpCode { get; set; }
        public string? Designation { get; set; }
        public string? Type { get; set; }
        public int? LoctionId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
