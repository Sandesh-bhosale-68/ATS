using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class DesignationWiseLevel
    {
        public int LevelId { get; set; }
        public string? Designation { get; set; }
        public int? Levels { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
