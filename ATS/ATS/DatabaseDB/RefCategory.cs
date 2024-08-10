using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RefCategory
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
