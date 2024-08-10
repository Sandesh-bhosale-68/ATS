using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class UpdatedTrainingDay
    {
        public double? Id { get; set; }
        public string? DeptName { get; set; }
        public string? SubDeptName { get; set; }
        public string? Location { get; set; }
        public string? TrainingPaid { get; set; }
        public double? TrainingDays { get; set; }
        public double? CertificationDays { get; set; }
        public double? TotalTrainingDays { get; set; }
        public string? UpdatedTrainingPaidStatus { get; set; }
        public double? UpdatedTotalTrainingDays { get; set; }
    }
}
