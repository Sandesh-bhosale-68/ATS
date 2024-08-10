using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblDesignation
    {
        public int Id { get; set; }
        public int? DepartMentId { get; set; }
        public string? DesignationName { get; set; }
        public long? Level { get; set; }
    }
}
