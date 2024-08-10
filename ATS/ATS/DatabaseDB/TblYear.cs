using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblYear
    {
        public int Id { get; set; }
        public long? Year { get; set; }
        public string? Month { get; set; }
    }
}
