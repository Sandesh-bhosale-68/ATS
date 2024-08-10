using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpDeactivationDetail
    {
        public long Id { get; set; }
        public string? EmpCode { get; set; }
        public string? Type { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public string? IrVrNrDate { get; set; }
        public string? IsDomainUser { get; set; }
    }
}
