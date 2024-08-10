using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class FeMaster
    {
        public int Id { get; set; }
        public string? FeName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
