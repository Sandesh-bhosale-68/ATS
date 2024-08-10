using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrmisLocationAccess
    {
        public decimal Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string LocationId { get; set; } = null!;
        public int? HrLocationId { get; set; }
        public string? Name { get; set; }
        public string? GroupName { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
