using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrRequisition
    {
        public int RequestId { get; set; }
        public string? Location { get; set; }
        public string? Department { get; set; }
        public string? SubDepartment { get; set; }
        public string? Process { get; set; }
        public string? Designation { get; set; }
        public string? RequiredSkills { get; set; }
        public string? Language { get; set; }
        public int? NoOfCandidatesRequired { get; set; }
        public DateTime? OnBoardDate { get; set; }
        public string? TlOpoid { get; set; }
        public string? ManagerOpoid { get; set; }
        public string? Status { get; set; }
        public DateTime? StatusUpdatedOn { get; set; }
        public DateTime? InsertDate { get; set; }
        public decimal? Graduate { get; set; }
        public decimal? UnderGraduate { get; set; }
        public decimal? GraduatePercentsplit { get; set; }
        public decimal? UnderGraduatePercentsplit { get; set; }
        public string? IsTrainingpaid { get; set; }
        public decimal? MaleSplit { get; set; }
        public decimal? FemaleSplit { get; set; }
        public string? JobDecryption { get; set; }
        public string? Type { get; set; }
        public string? VersantRequired { get; set; }
        public string? VersantLevel { get; set; }
        public string? BgvRequired { get; set; }
        public string? BatchCode { get; set; }
    }
}
