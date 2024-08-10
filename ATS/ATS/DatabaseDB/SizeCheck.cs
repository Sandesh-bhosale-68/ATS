using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SizeCheck
    {
        public string TableName { get; set; } = null!;
        public long? NumRows { get; set; }
        public string? ReservedSpace { get; set; }
        public string? Dataspace { get; set; }
        public string? IndexSize { get; set; }
        public string? UnusedSpace { get; set; }
    }
}
