using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SubSource
    {
        public int SubSourceId { get; set; }
        public string SubSourceName { get; set; } = null!;
        public int SourceId { get; set; }
    }
}
