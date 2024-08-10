using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RefIjpactive
    {
        public int Id { get; set; }
        public string? Process { get; set; }
        public string? Designation { get; set; }
        public string? Description { get; set; }
        public string? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
