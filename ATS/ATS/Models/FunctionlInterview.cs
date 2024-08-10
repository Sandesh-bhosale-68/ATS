using Newtonsoft.Json;

namespace ATS.Models
{
    public class FunctionlInterview
    {
        //    [JsonProperty("InterviewStage")]
        //    public string InterviewStage { get; set; }

        //    [JsonProperty("Department")]
        //    public string Department { get; set; }

        //    [JsonProperty("Interviewer")]
        //    public string Interviewer { get; set; }

        //    [JsonProperty("Date")]
        //    public DateTime Date { get; set; }

        //    [JsonProperty("Time")]
        //    public TimeSpan Time { get; set; }

        //    [JsonProperty("MeetingLink")]
        //    public string MeetingLink { get; set; }

        //    [JsonProperty("CandidateEmail")]
        //    public string CandidateEmail { get; set; }


        public string InterviewStage { get; set; }
        public string Department { get; set; }
        public string Interviewer { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan SelectedTime { get; set; }
        public string Meeting { get; set; }
        public string Email { get; set; }

    }
}
