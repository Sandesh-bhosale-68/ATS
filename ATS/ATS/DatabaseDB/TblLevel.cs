using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblLevel
    {
        public int Id { get; set; }
        public string? Designation { get; set; }
        public string? Level { get; set; }
        public int? LevelId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
