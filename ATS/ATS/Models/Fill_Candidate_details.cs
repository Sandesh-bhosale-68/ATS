using ATS.DatabaseDB;

namespace ATS.Models
{
    public class Fill_Candidate_details
    {
        public int? SelectedSourceId { get; set; }
        public string? Source { get; set; }
        public string? SubSource { get; set; }
        public string? Location { get; set; }
        public string? Position { get; set; }
        public IFormFile Photograph { get; set; }
        public List<Source>? SourceOptions { get; set; } = new List<Source>(); // Initialize the list
    }
}
