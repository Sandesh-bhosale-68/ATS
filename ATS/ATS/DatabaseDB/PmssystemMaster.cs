using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class PmssystemMaster
    {
        public int Id { get; set; }
        public int? PmapsUniqueId { get; set; }
        public int? MasterId { get; set; }
        public string? AadharCardNo { get; set; }
        public string? TestFitment { get; set; }
        public string? Section1Name { get; set; }
        public string? Section1Result { get; set; }
        public decimal? Section1Scores { get; set; }
        public string? Section2Name { get; set; }
        public string? Section2Result { get; set; }
        public decimal? Section2Scores { get; set; }
        public string? Section3Name { get; set; }
        public string? Section3Result { get; set; }
        public decimal? Section3Scores { get; set; }
        public string? PsySection1Name { get; set; }
        public string? PsySection1Result { get; set; }
        public decimal? PsySection1Scores { get; set; }
        public string? PsySection1Trait1Name { get; set; }
        public decimal? PsySection1Trait1Percentage { get; set; }
        public string? PsySection1Trait1Result { get; set; }
        public string? PsySection1Trait2Name { get; set; }
        public decimal? PsySection1Trait2Percentage { get; set; }
        public string? PsySection1Trait2Result { get; set; }
        public string? PsySection1Trait3Name { get; set; }
        public decimal? PsySection1Trait3Percentage { get; set; }
        public string? PsySection1Trait3Result { get; set; }
        public string? PsySection1Trait4Name { get; set; }
        public decimal? PsySection1Trait4Percentage { get; set; }
        public string? PsySection1Trait4Result { get; set; }
        public string? PsySection1Trait5Name { get; set; }
        public decimal? PsySection1Trait5Percentage { get; set; }
        public string? PsySection1Trait5Result { get; set; }
    }
}
