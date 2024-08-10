using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvAvgRating
    {
        public long? ThemeId { get; set; }
        public long SrvId { get; set; }
        public string? QName { get; set; }
        public double? QValue { get; set; }
    }
}
