using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblBusinessType
    {
        public long Id { get; set; }
        public string? BusinessType { get; set; }
        public string? Code { get; set; }
        public bool? Isactive { get; set; }
    }
}
