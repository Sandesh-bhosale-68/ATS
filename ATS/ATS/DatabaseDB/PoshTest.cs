using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class PoshTest
    {
        public decimal PoshTestId { get; set; }
        public string EmpCode { get; set; } = null!;
        public decimal PoshQaId { get; set; }
        public string? ActualAnswer { get; set; }
        public string? GivenAnswer { get; set; }
        public bool? Result { get; set; }
        public int? Attempt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual PoshQa PoshQa { get; set; } = null!;
    }
}
