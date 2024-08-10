using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RefCandidateByEmployeeActive
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? MobileNo { get; set; }
        public string? Alternate { get; set; }
        public string? Designation { get; set; }
        public string? WorkExperience { get; set; }
        public string? CurrentCompanyName { get; set; }
        public string? GivenBy { get; set; }
        public string? Address { get; set; }
        public string? Qualification { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
