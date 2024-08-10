using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RequisitionHrdatum
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public string? Batchid { get; set; }
        public int? NoOfCandidates { get; set; }
        public DateTime? Onboarddate { get; set; }
        public string? HrOpoid { get; set; }
        public DateTime? InsertDate { get; set; }
        public string? TrainerName { get; set; }
        public string? TrainerOpoid { get; set; }
        public string? TrainerManager { get; set; }
        public DateTime? TrainingStartdate { get; set; }
        public DateTime? TrainingEnddate { get; set; }
        public DateTime? OjtStartdate { get; set; }
        public DateTime? OjtEnddate { get; set; }
        public DateTime? BatchAssigndate { get; set; }
        public string? TrainerAllocation { get; set; }
        public string? TrainerClientFreelance { get; set; }
        public DateTime? HoldDate { get; set; }
        public DateTime? ActualTrainingDate { get; set; }
        public string? ActualTrainer { get; set; }
        public string? ActualTrainerOpoid { get; set; }
        public DateTime? ActualTrainingEnddate { get; set; }
        public DateTime? ActualOjtStartdate { get; set; }
        public DateTime? ActualOjtEnddate { get; set; }
    }
}
