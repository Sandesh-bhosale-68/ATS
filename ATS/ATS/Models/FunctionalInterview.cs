namespace ATS.Models
{
    public class FunctionalInterview
    {
        public string InterviewStage { get; set; }

        // Properties for Select Department section
        public string Department { get; set; }

        // Properties for Select Interviewer section
        public string Interviewer { get; set; }

        // Properties for Select Date and Select Time sections
        public DateTime Date { get; set; }
    

        // Property for Meeting Link section
        public string Meeting { get; set; }

        // Property for Candidate Email ID section
   
    }
}
