using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssAttendanceRequest
    {
        public int Id { get; set; }
        public string AttDate { get; set; } = null!;
        public string? AttStatus { get; set; }
        public string Empcode { get; set; } = null!;
        public string? AttComments { get; set; }
        public int? RequestStatus { get; set; }
        public string? Empcodelm { get; set; }
        public string? ApprovedEmpcodelm { get; set; }
        public string? SupervisorComments { get; set; }
        public string? Comment { get; set; }
        public string? ExistingStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
