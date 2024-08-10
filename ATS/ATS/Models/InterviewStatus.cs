using System.ComponentModel.DataAnnotations;

namespace ATS.Models
{
    public class InterviewStatus
    {
        [Key]
        public int ID { get; set; }
        public int MasterId { get; set; }
        public string CandidateName { get; set; }
        public int CognitiveTest { get; set; }
        public int BehaviourTest { get; set; }
        public int TypingTest { get; set; }
        public int VerbalTest { get; set; }
        public double? AverageScore { get; set; } // Use nullable double if AverageScore can be null
        public string Interview1 { get; set; }
        public string Interview2 { get; set; }
        public string Interview3 { get; set; }
    }
}
