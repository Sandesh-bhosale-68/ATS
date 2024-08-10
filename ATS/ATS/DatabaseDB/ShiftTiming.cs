using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ShiftTiming
    {
        public int Id { get; set; }
        public string ShiftName { get; set; } = null!;
        public DateTime Intime { get; set; }
        public DateTime Outtime { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
