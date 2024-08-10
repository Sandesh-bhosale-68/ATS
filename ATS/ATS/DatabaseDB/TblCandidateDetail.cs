using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATS.DatabaseDB
{
    public partial class TblCandidateDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Masterid { get; set; }
        public string? Empcode { get; set; }
        public string? Prefix { get; set; }
        public string? Fname { get; set; }
        public string? Mname { get; set; }
        public string? Lname { get; set; }
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Fathername { get; set; }
        public string? Mothername { get; set; }
        public string? Emaild { get; set; }
        public string? Fulladdr1 { get; set; }
        public string? Faddr1 { get; set; }
        public string? Faddr2 { get; set; }
        public string? Faddr3 { get; set; }
        public string? Faddr4 { get; set; }
        public string? Fmobile { get; set; }
        public string? Flandline { get; set; }
        public string? Fulladdr2 { get; set; }
        public string? Saddr1 { get; set; }
        public string? Saddr2 { get; set; }
        public string? Saddr3 { get; set; }
        public string? Saddr4 { get; set; }
        public string? Smobile { get; set; }
        public string? Slandline { get; set; }
        public string? Maritialstatus { get; set; }
        public string? Anivdate { get; set; }
        public string? Spousename { get; set; }
        public string? Nameofchildren { get; set; }
        public string? Bloodgrp { get; set; }
        public string? Emergcontno { get; set; }
        public string? Emergcontperson { get; set; }
        public string? Anyotherquali { get; set; }
        public string? Totalexpr { get; set; }
        public string? Prorefname { get; set; }
        public string? Prorefdesig { get; set; }
        public string? Prorefcontact { get; set; }
        public string? Famrefname { get; set; }
        public string? Famrefcontact { get; set; }
        public string? Frdrefname { get; set; }
        public string? Frdrefcontact { get; set; }
        public string? Refrecname { get; set; }
        public string? Refreccontact { get; set; }
        public string? Refreccuremp { get; set; }
        public string? Refrecdesig { get; set; }
        public string? Lastctcpm { get; set; }
        public DateTime? Dateoftraining { get; set; }
        public DateTime? Dateofjoining { get; set; }
        public string? Location { get; set; }
        public string? Department { get; set; }
        public string? Subdepartment { get; set; }
        public string? Subdepartment1 { get; set; }
        public string? Joiningdesig { get; set; }
        public string? Currentdesig { get; set; }
        public string? Placeofbirth { get; set; }
        public string? Nationality { get; set; }
        public string? Religion { get; set; }
        public string? Languages { get; set; }
        public string? Passportno { get; set; }
        public string? Caste { get; set; }
        public string? Identificationmark { get; set; }
        public string? Handicap { get; set; }
        public string? Handicapnature { get; set; }
        public string? Handicapper { get; set; }
        public DateTime? Licenseexpirydt { get; set; }
        public string? Subcaste { get; set; }
        public string? Issueofrltr { get; set; }
        public DateTime? Interviewdt { get; set; }
        public string? Issueapptltr { get; set; }
        public string? Postappliedfor { get; set; }
        public DateTime? Entrydttm { get; set; }
        public string? Interviewstatus { get; set; }
        public string? Interviewtm { get; set; }
        public string? Postassigned { get; set; }
        public string? TeleRound { get; set; }
        public string? Mode { get; set; }
        public string? ModeHrperson { get; set; }
        public string? Photoid { get; set; }
        public string? Interviewer { get; set; }
        public byte? IntrvFlag { get; set; }
        public string? InternalRef { get; set; }
        public string? InfFlag { get; set; }
        public string? AnnualCtc { get; set; }
        public DateTime? OfferLetterDate { get; set; }
        public DateTime? ActualDoj { get; set; }
        public byte? HasJoined { get; set; }
        public int? TrngBatchId { get; set; }
        public string? TrainerEmpId { get; set; }
        public string? TrainerName { get; set; }
        public byte? IsRejected { get; set; }
        public string? TrngStatus { get; set; }
        public string? ConsaltantRef { get; set; }
        public string? EntryUpdatedbyDt { get; set; }
        public string? HrLocation { get; set; }
        public string? ClosedBy { get; set; }
        public int? PinCodeForCurrent { get; set; }
        public int? PinCodeForPermanant { get; set; }
        public string? EffortRefName { get; set; }
        public string? EffortRefContactNo { get; set; }
        public string? EffortRefEmpid { get; set; }
        public int? LocationId { get; set; }
        public string? CertificationComments { get; set; }
        public string? TrngSubStatus { get; set; }
        public string? CurrentArea { get; set; }
        public string? CurrentLandmark { get; set; }
        public string? PermArea { get; set; }
        public string? PermLandmark { get; set; }
        public string? PanCard { get; set; }
        public string? AadharCard { get; set; }
        public string? AadharStatus { get; set; }
        public string? AdharName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? Uanno { get; set; }
        public decimal? BasicDaRate { get; set; }
        public decimal? GrossSalPli { get; set; }
        public string? PfMember { get; set; }
        public string? PensionMember { get; set; }
        public string? PfNo { get; set; }
        public DateTime? DolPrev { get; set; }
        public string? PfWithdrawStatus { get; set; }
        public string? Remark { get; set; }
        public string? BankLocation { get; set; }
        public string? AccNo { get; set; }
        public string? Ifsccode { get; set; }
        public string? CandidateLocation { get; set; }
        public string? Purpose { get; set; }
        public string? SubDeptName { get; set; }
        public string? Round1 { get; set; }
        public string? Round2 { get; set; }
        public string? Round3 { get; set; }
        public string? Round4 { get; set; }
        public string? HighestQualification { get; set; }
        public string? YearofPassing { get; set; }
        public string? Percentage { get; set; }
        public string? CreatedBy { get; set; }
        public string? DifferentlyAbled { get; set; }
        public string? EmploymentStatus { get; set; }
        public string? FtPt { get; set; }
        public string? WfoWfh { get; set; }
        public string? PfApplicability { get; set; }
        

        public string? EsicApplicability { get; set; }
      
    }
}
