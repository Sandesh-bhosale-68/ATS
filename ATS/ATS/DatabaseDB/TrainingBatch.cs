using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TrainingBatch
    {
        public int TrainingId { get; set; }
        public DateTime? TrainingStartdate { get; set; }
        public DateTime? TrainingEnddate { get; set; }
        public DateTime? OpsHandoverDate { get; set; }
        public string? TrainingDept { get; set; }
        public string? TrainingSubdept { get; set; }
        public string? Trainer { get; set; }
        public string? Status { get; set; }
        public string? TranerEbl { get; set; }
        public string? TransferFrom { get; set; }
        public DateTime? TransferDate { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? BatchName { get; set; }
    }
}
