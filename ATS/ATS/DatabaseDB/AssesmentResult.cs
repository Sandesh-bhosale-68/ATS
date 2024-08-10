using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class AssesmentResult
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? CandidateName { get; set; }
        public int? CognitiveTest { get; set; }
        public int? BehaviourTest { get; set; }
        public int? TypingTest { get; set; }
        public int? VerbalTest { get; set; }
        public double? AverageScore { get; set; }
        public string? Interview1 { get; set; }
        public string? Interview2 { get; set; }
        public string? Interview3 { get; set; }
    }
}
