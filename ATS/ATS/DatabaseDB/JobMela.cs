using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class JobMela
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public int? LocationId { get; set; }
        public string? Location { get; set; }
        public string? EmailId { get; set; }
        public string? AdharNo { get; set; }
        public string? HighestQualification { get; set; }
        public string? SpecialCourses { get; set; }
        public string? Marathi { get; set; }
        public string? English { get; set; }
        public string? Hindi { get; set; }
        public string? OtherLanguage1 { get; set; }
        public string? Other1 { get; set; }
        public string? OtherLanguage2 { get; set; }
        public string? Other2 { get; set; }
        public string? Reference1Name { get; set; }
        public string? Reference1Phone { get; set; }
        public string? Reference2Name { get; set; }
        public string? Reference2Phone { get; set; }
        public string? MobileNumber { get; set; }
        public string? Otp { get; set; }
        public string? RegistartionNumber { get; set; }
        public string? HrExecutive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
