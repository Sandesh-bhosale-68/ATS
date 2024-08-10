namespace ATS.DatabaseDB
{
    public partial class InterviewrsDept
    {
        public int InterviewId { get; set; }
        public int? DepartmentId { get; set; }
        public string InterviewerName { get; set; } = null!;
        public string InterviewEmail { get; set; } = null!;
    }
}
