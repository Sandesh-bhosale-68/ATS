using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class PoshQa
    {
        public PoshQa()
        {
            PoshTests = new HashSet<PoshTest>();
        }

        public decimal PoshQaId { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }

        public virtual ICollection<PoshTest> PoshTests { get; set; }
    }
}
