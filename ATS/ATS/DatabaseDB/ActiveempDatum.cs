using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class ActiveempDatum
    {
        public string? CurrentLocation { get; set; }
        public byte? StatusActiveInactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string Empcode { get; set; } = null!;
        public string? Prefix { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public string Gender { get; set; } = null!;
        public string? FathersName { get; set; }
        public string? MothersMaidenName { get; set; }
        public string? ResiNo { get; set; }
        public string? MobileNo { get; set; }
        public string? EMailId { get; set; }
        public string? Languages { get; set; }
        public string MaritalStatus { get; set; } = null!;
        public DateTime? DateOfTraining { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string? Location { get; set; }
        public string? Department { get; set; }
        public string? SubDepartment { get; set; }
        public string? Grade { get; set; }
        public string? JoiningDesignation { get; set; }
        public string? CurrentDesignation { get; set; }
        public string? LineManager { get; set; }
        public string? OphandOverBy { get; set; }
        public DateTime? OphandOverDate { get; set; }
        public double? Ctc { get; set; }
        public string? AadharCard { get; set; }
        public string? PanCard { get; set; }
        public string? Pfno { get; set; }
        public long? Uanno { get; set; }
        public string? Esicno { get; set; }
        public string? Status { get; set; }
        public string? Hssboard { get; set; }
        public string? Hssyear { get; set; }
        public string? Hssper { get; set; }
        public string? HssStream { get; set; }
        public string? Hsboard { get; set; }
        public string? Hsyear { get; set; }
        public string? Hsper { get; set; }
        public string? Hsstream { get; set; }
        public string? Gboard { get; set; }
        public string? Gyear { get; set; }
        public string? Gper { get; set; }
        public string? Gstream { get; set; }
        public string? Pgboard { get; set; }
        public string? Pgyear { get; set; }
        public string? Pgper { get; set; }
        public string? Pstream { get; set; }
        public string? OtherQua { get; set; }
        public string? CurrentStreet { get; set; }
        public string? CurrentCity { get; set; }
        public string? CurrentState { get; set; }
        public string? PermanentStreet { get; set; }
        public string? PermanentCity { get; set; }
        public string? PermanentState { get; set; }
    }
}
