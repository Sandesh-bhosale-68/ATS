using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TempTrainerdatum
    {
        public long Id { get; set; }
        public decimal? MasterId { get; set; }
        public string? CandidateName { get; set; }
        public string? Process { get; set; }
        public string? TrainerMgrEmpcode { get; set; }
        public DateTime? Recdate { get; set; }
        public DateTime? DateOfTraining { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string? BatchId { get; set; }
        public DateTime? BatchEndDate { get; set; }
        public string? BatchStatus { get; set; }
        public string? TrainerEmpcode { get; set; }
    }
}
