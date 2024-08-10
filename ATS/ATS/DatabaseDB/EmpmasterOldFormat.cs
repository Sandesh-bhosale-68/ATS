using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpmasterOldFormat
    {
        public decimal Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? VerifiedId { get; set; }
        public decimal? CardNo { get; set; }
        public string? Prefix { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string? FathersName { get; set; }
        public string? MothersMaidenName { get; set; }
        public string? MaritalStatus { get; set; }
        public DateTime? AnnivDate { get; set; }
        public string? SpouseName { get; set; }
        public string? Nameofchildren { get; set; }
        public string? BloodGroup { get; set; }
        public string? MedicalHistory { get; set; }
        public string? OpoEmailId { get; set; }
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
        public string? LastCtcpa { get; set; }
        public string? WorkingExperience { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? Dot { get; set; }
        public DateTime? Doc { get; set; }
        public string? Status { get; set; }
        public string? NoticePeriod { get; set; }
        public string? CurrentLocation { get; set; }
        public int? Currentlocationid { get; set; }
        public string? Department { get; set; }
        public string? SubDept { get; set; }
        public string? Subdepartment1 { get; set; }
        public string? Grade { get; set; }
        public string? JoiningDesignation { get; set; }
        public string? CurrentDesignation { get; set; }
        public string? EmpCodeLm { get; set; }
        public string? Photo { get; set; }
        public double? Ctc { get; set; }
        public string? Placeofbirth { get; set; }
        public string? Nationality { get; set; }
        public string? Religion { get; set; }
        public string? Languages { get; set; }
        public string? Fnfdone { get; set; }
        public string? ExitStatus { get; set; }
        public string? Tenure { get; set; }
        public double? LastCtcDrawn { get; set; }
        public string? Identificationmark { get; set; }
        public string? Handicap { get; set; }
        public string? Handicapnature { get; set; }
        public string? Handicapper { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? LogFlag { get; set; }
        public byte? IntrvFlag { get; set; }
        public string? AccessType { get; set; }
        public string? GroupName { get; set; }
        public byte? ActiveEmp { get; set; }
        public byte? InactiveAdnFnf { get; set; }
        public DateTime? RejoiningDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string? HrLocation { get; set; }
        public int? BlackListed { get; set; }
        public string? ActivatedBy { get; set; }
        public int? StatusId { get; set; }
        public int? EmployeeType { get; set; }
        public double? PaidLeave { get; set; }
        public string? WindowId { get; set; }
        public string? UserId { get; set; }
        public string? DialerId { get; set; }
        public string? EmailId { get; set; }
        public byte? EmailId0nr1r { get; set; }
        public byte? WindowsId0nr1r { get; set; }
        public DateTime? ResignationDate { get; set; }
        public DateTime? OfferLetterDate { get; set; }
        public DateTime? OpoJoiningDate { get; set; }
        public string? PreviousSubDept { get; set; }
        public DateTime? TransferDate { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
