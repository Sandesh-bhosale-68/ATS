using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssShiftstatus
    {
        public int Id { get; set; }
        public string? ShiftStatus { get; set; }
        public string? ShiftDesc { get; set; }
    }
}
