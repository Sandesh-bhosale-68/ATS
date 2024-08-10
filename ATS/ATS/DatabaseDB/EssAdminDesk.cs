using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssAdminDesk
    {
        public int EssAdminDeskId { get; set; }
        public string? EssCode { get; set; }
        public string? EssName { get; set; }
        public string? EssDepartment { get; set; }
        public string? EssLocation { get; set; }
        public string? EssDescription { get; set; }
        public DateTime? EssRequestDate { get; set; }
    }
}
