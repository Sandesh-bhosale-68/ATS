using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ShiftDetails20231128
    {
        public int Id { get; set; }
        public string ShiftName { get; set; } = null!;
        public DateTime? Intime { get; set; }
        public DateTime? Outtime { get; set; }
        public string Process { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
    }
}
