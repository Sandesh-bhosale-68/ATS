using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DesignationWiseWocountHd
    {
        public int Id { get; set; }
        public string? Designation { get; set; }
        public int? Wocount { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
