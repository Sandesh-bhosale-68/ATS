using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class WarningLevel
    {
        public int Id { get; set; }
        public string? WarningLevel1 { get; set; }
        public int? LevelId { get; set; }
    }
}
