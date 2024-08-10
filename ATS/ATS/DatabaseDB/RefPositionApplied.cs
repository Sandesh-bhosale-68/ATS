using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RefPositionApplied
    {
        public int Id { get; set; }
        public string? PositionAvailable { get; set; }
        public int? NoOfSeats { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
