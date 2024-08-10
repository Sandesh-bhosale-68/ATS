using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RAttAcceptRosterRemove
    {
        public decimal Id { get; set; }
        public string? Empcode { get; set; }
        public string? AttDate { get; set; }
        public string? AttShift { get; set; }
        public DateTime? Intime { get; set; }
        public DateTime? Outtime { get; set; }
        public string? EmpCodeLm { get; set; }
        public int? RequestStatus { get; set; }
        public string? RequestReason { get; set; }
        public string? SuperviserComment { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
