using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RosterDetailsDeleted20230908
    {
        public decimal Id { get; set; }
        public string Empcode { get; set; } = null!;
        public string AttDate { get; set; } = null!;
        public string? AttShift { get; set; }
        public DateTime? Intime { get; set; }
        public DateTime? Outtime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? UpdateEmpcode { get; set; }
        public string? Location { get; set; }
        public string? Remark { get; set; }
        public DateTime? Codate { get; set; }
    }
}
