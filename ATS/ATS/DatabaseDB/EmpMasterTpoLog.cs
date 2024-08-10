﻿using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpMasterTpoLog
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
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContact { get; set; }
        public string? Emailid { get; set; }
        public string? OpoEmailId { get; set; }
        public string? CurrentHouseNo { get; set; }
        public string? CurrentStreet { get; set; }
        public string? CurrentCity { get; set; }
        public string? CurrentState { get; set; }
        public string? CurrentArea { get; set; }
        public string? CurrentLandmark { get; set; }
        public int? CurrentZip { get; set; }
        public string? CurrentPhone { get; set; }
        public string? CurrentMobile { get; set; }
        public string? PermanentHouseNo { get; set; }
        public string? PermanentStreet { get; set; }
        public string? PermanentCity { get; set; }
        public string? PermanentState { get; set; }
        public string? PermanentArea { get; set; }
        public string? PermanentLandmark { get; set; }
        public int? PermanentZip { get; set; }
        public string? PermanentPhone { get; set; }
        public string? PermanentMobile { get; set; }
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
        public string? Company1 { get; set; }
        public string? Designation1 { get; set; }
        public string? Company2 { get; set; }
        public string? Designation2 { get; set; }
        public string? Company3 { get; set; }
        public string? Designation3 { get; set; }
        public string? Company4 { get; set; }
        public string? Designation4 { get; set; }
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
        public string? Bank { get; set; }
        public string? Branch { get; set; }
        public string? AccNo { get; set; }
        public string? BankType { get; set; }
        public double? Ctc { get; set; }
        public string? Placeofbirth { get; set; }
        public string? Nationality { get; set; }
        public string? Religion { get; set; }
        public string? Languages { get; set; }
        public string? Passportno { get; set; }
        public string? Fnfdone { get; set; }
        public string? ExitStatus { get; set; }
        public string? Tenure { get; set; }
        public double? LastCtcDrawn { get; set; }
        public string? Identificationmark { get; set; }
        public string? Handicap { get; set; }
        public string? Handicapnature { get; set; }
        public string? Handicapper { get; set; }
        public string? AccessRole { get; set; }
        public string? Password { get; set; }
        public int? Rights { get; set; }
        public string? ModifiedBy { get; set; }
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
        public string? RefCheckedNo { get; set; }
        public string? RefCheckedName { get; set; }
        public string? RefEmpcode { get; set; }
        public string? RefFamilyRelationInEbl { get; set; }
        public string? RefDesignation { get; set; }
        public string? RefDepartment { get; set; }
        public string? RefSubDepartment { get; set; }
        public int? StatusId { get; set; }
        public string? EmployeeType { get; set; }
        public double? PaidLeave { get; set; }
        public string? AdharCardNo { get; set; }
        public string? PanCardNo { get; set; }
        public string? PreviousEmpcode { get; set; }
        public string? WindowId { get; set; }
        public string? UserId { get; set; }
        public string? DialerId { get; set; }
        public string? EmailId1 { get; set; }
        public string? SparkId { get; set; }
        public byte? EmailId0nr1r { get; set; }
        public byte? WindowsId0nr1r { get; set; }
        public byte? SparkId0nr1r { get; set; }
        public DateTime? ResignationDate { get; set; }
        public DateTime? OfferLetterDate { get; set; }
        public DateTime? OpoJoiningDate { get; set; }
        public string? PreviousSubDept { get; set; }
        public DateTime? TransferDate { get; set; }
        public string? Pfstatus { get; set; }
        public string? Pfno { get; set; }
        public string? Esicstatus { get; set; }
        public string? Esicno { get; set; }
        public string? Ifsccode { get; set; }
        public DateTime? DesigEffectedDate { get; set; }
        public DateTime? OphandOverDate { get; set; }
        public string? OphandOverBy { get; set; }
        public string? TrngBatchId { get; set; }
        public string? TrngStatus { get; set; }
        public string? TrngSubStatus { get; set; }
        public byte? Isrejected { get; set; }
        public string? CertificationComments { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public bool? HrBucket { get; set; }
        public string? RevisedCtc { get; set; }
        public string? RevisedDesignation { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? AdharName { get; set; }
        public string? EmpLevel { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Levels { get; set; }
        public int? PmapsScore { get; set; }
        public int? VersantScore { get; set; }
        public int? CompOff { get; set; }
        public string? FacebookId { get; set; }
        public string? LinkedInId { get; set; }
        public string? InstagramId { get; set; }
        public string? CreatedBy { get; set; }
        public bool? IsPoshtestDone { get; set; }
        public string? NameoOfAadhar { get; set; }
        public long? Uanno { get; set; }
        public decimal? BasicDaRate { get; set; }
        public decimal? GrossSalPli { get; set; }
        public string? PfMember { get; set; }
        public string? PensionMember { get; set; }
        public string? PfNo1 { get; set; }
        public DateTime? DolPrev { get; set; }
        public string? PfWithdrawStatus { get; set; }
        public string? Remark { get; set; }
        public string? BankLocation { get; set; }
        public DateTime? EffortLastDate { get; set; }
        public string? Interviewed { get; set; }
        public string? Ismailconfirmed { get; set; }
        public string? NoticePeriodStatus { get; set; }
        public string? VaccinationStatus { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? FtPt { get; set; }
        public string? WfoWfh { get; set; }
        public string? PfApplicability { get; set; }
        public string? EsicApplicability { get; set; }
        public string? ContractCode { get; set; }
        public string? TemporaryEmpCode { get; set; }
        public int? TrnfTpoToOpo { get; set; }
    }
}
