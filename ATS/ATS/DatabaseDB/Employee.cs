﻿using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string EmployeeCode { get; set; } = null!;
        public string? StringCode { get; set; }
        public long? NumericCode { get; set; }
        public string Gender { get; set; } = null!;
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public string? Designation { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? Dor { get; set; }
        public DateTime? Doc { get; set; }
        public string EmployeeCodeInDevice { get; set; } = null!;
        public string? EmployeeRfidnumber { get; set; }
        public string EmployementType { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? EmployeeDevicePassword { get; set; }
        public string? EmployeeDeviceGroup { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? ResidentialAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public DateTime? Dob { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Nomenee1 { get; set; }
        public string? Nomenee2 { get; set; }
        public string? Remarks { get; set; }
        public int? RecordStatus { get; set; }
        public string? Bloodgroup { get; set; }
        public string? WorkPlace { get; set; }
        public string? ExtensionNo { get; set; }
        public string? LoginName { get; set; }
        public string? LoginPassword { get; set; }
        public string? Grade { get; set; }
        public string? Team { get; set; }
        public int? IsRecieveNotification { get; set; }
        public int? HolidayGroup { get; set; }
        public int? ShiftGroupId { get; set; }
        public string? LastModifiedBy { get; set; }
        public int? ShiftRotationMasterId { get; set; }
        public string? ReportTo { get; set; }
        public string? ShiftType { get; set; }
        public string? OfficialPhone { get; set; }
        public string? OfficialMobile { get; set; }
        public string? PersonaleMailId { get; set; }
        public string? Uidno { get; set; }
        public string? Panno { get; set; }
        public string? VoterIdNo { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? ShiftPatternAssignedOn { get; set; }
        public int? MultiShiftGroupId { get; set; }
        public string? PushNotificationId { get; set; }
        public int? IsSendApproveDeclineSms { get; set; }
        public int? IsSendPushNotification { get; set; }
        public int? EmployeeAddedFromService { get; set; }
        public string? AndroidDeviceImeino { get; set; }
        public int? IsMarkAndroidWebAttendance { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? ModeOfPayment { get; set; }
        public string? Esino { get; set; }
        public string? Esidispensary { get; set; }
        public string? Pfno { get; set; }
        public int? SalaryStructureId { get; set; }
        public DateTime? LeaveCreditFromDate { get; set; }
        public string? Nationality { get; set; }
        public string? DutiesAndResponsibilities { get; set; }
        public string? PassportNumber { get; set; }
        public DateTime? DurationOfEmpFromDate { get; set; }
        public DateTime? DurationOfEmpToDate { get; set; }
        public int? IsContractEmployeeAtt { get; set; }
        public DateTime? PassportExpireOn { get; set; }
        public DateTime? FrinexpireOn { get; set; }
        public int? CtakeUnlimitedLe { get; set; }
        public bool? Isesino { get; set; }
        public bool? Ispfno { get; set; }
        public string? PfnoDeptFile { get; set; }
        public bool? IsRestrictPfcontri { get; set; }
        public bool? IsZeroPension { get; set; }
        public bool? IsZeroPt { get; set; }
        public bool? IsTdsapplicable { get; set; }
        public string? WardCircle { get; set; }
        public bool? IsMetro { get; set; }
        public bool? IsEmployerPfrestrict { get; set; }
        public bool? IsContractEmployee { get; set; }
        public bool? Isgratuity { get; set; }
        public string? ReasonForLeaving { get; set; }
        public string? ResignationCode { get; set; }
        public DateTime? SettlementDate { get; set; }
        public DateTime? SalaryHoldFrom { get; set; }
        public bool? IsFinalSettlementDone { get; set; }
        public DateTime? PfapplicabilityEffectiveFrom { get; set; }
        public DateTime? RestrictEmployeePfeffectiveFrom { get; set; }
        public DateTime? ZeroPensionApplicabilityEffectiveFrom { get; set; }
        public DateTime? ZeroPtapplicabilityFrom { get; set; }
        public DateTime? EsiapplicabilityEffectiveFrom { get; set; }
        public DateTime? RestrictEmployerPfeffectiveFrom { get; set; }
        public bool? EsiapplicabilityFirstHalf { get; set; }
        public bool? EsiapplicabilitySecondHalf { get; set; }
        public DateTime? ProbationCompletionDate { get; set; }
        public DateTime? FinalSettlementSalaryHoldFrom { get; set; }
        public DateTime? ExitInterviewDate { get; set; }
        public string? ExitInterviewRemarks { get; set; }
        public string? ExitRemarks { get; set; }
        public DateTime? ResignationSubmittedOn { get; set; }
        public DateTime? TentativeLeavingDate { get; set; }
        public int? ShortFallInNotice { get; set; }
        public int? NoticePeriodDays { get; set; }
        public string? SpouseName { get; set; }
        public DateTime? DateOfJoiningPf { get; set; }
        public DateTime? DateOfExitPf { get; set; }
        public int? FinancialInstitutionId { get; set; }
        public string? DrivingLicenseNo { get; set; }
        public string? AadharCardNo { get; set; }
        public string? RationCardNo { get; set; }
        public string? PassportNo { get; set; }
        public string? Uanno { get; set; }
        public DateTime? SalaryCalculateFrom { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public string? AccountHolder { get; set; }
        public string? Ifsccode { get; set; }
        public int? IsZeroLwf { get; set; }
        public string? ModeOfSalaryCalculation { get; set; }
        public int? IsExcludePayroll { get; set; }
        public int? IsNavigateGmap { get; set; }
        public int? IsFingerPrintIssue { get; set; }
        public decimal? BasicRateDaily { get; set; }
        public int? IsNewOrOldEmployee { get; set; }
        public int? IsOldEmployee { get; set; }
        public int? IsOverridePfsetting { get; set; }
        public DateTime? LastMobileAppEsslogin { get; set; }
        public DateTime? LastWebEsslogin { get; set; }
        public int? MobilePunchTimeZoneId { get; set; }
        public string? PanStatus { get; set; }
        public string? MaritialStatus { get; set; }
        public decimal? DailyWage1 { get; set; }
        public decimal? DailyWage2 { get; set; }
        public decimal? DailyWage3 { get; set; }
        public decimal? DailyWage4 { get; set; }
        public decimal? DailyWage5 { get; set; }
        public decimal? DailyWage6 { get; set; }
        public int? IsIgnoreImeivalidation { get; set; }
        public int? Location { get; set; }
        public int? IsTdsnotApplicable { get; set; }
        public string? NameAsPerAadhar { get; set; }
        public string? HusbandName { get; set; }
        public int? ApplicableFinancialYearSetting { get; set; }
        public int? IsZeroHra { get; set; }
        public int? IsZeroPtdeduction { get; set; }
        public int? IsZeroItdeduction { get; set; }
        public int? IsZeroSection10Exemption { get; set; }
        public string? AccomodationType { get; set; }
        public string? StayingWith { get; set; }
        public string? EmergencyContact1Name { get; set; }
        public string? EmergencyContact1Number { get; set; }
        public string? EmergencyContact1Relation { get; set; }
        public string? EmergencyContact2Name { get; set; }
        public string? EmergencyContact2Number { get; set; }
        public string? EmergencyContact2Relation { get; set; }
        public int? IsCompnayHead { get; set; }
        public int? IsDepartmentHead { get; set; }
        public int? ExpensePolicyId { get; set; }
        public int? IsHrmanager { get; set; }
        public int? IsFinanceManager { get; set; }
        public int? IsAdminManager { get; set; }
        public int? IsOperationManager { get; set; }
        public int? ExitPolicyId { get; set; }
        public string? EmployeeDeviceToken { get; set; }
        public int? HelpDeskReviewDepartmentId { get; set; }
        public decimal? Nomenee1Per { get; set; }
        public decimal? Nomenee2Per { get; set; }
        public string? WebTokenId { get; set; }
        public DateTime? LastDeleteCommandTriggerOn { get; set; }
        public int? IsConfirm { get; set; }
        public int? IsEnableBgGeoLocation { get; set; }
        public int? IsShowBegindayEndDay { get; set; }
        public int? IsEnableAutoGeoFence { get; set; }
        public int? IsEnableAutoLocationFetch { get; set; }
        public int? IsInternationalWorker { get; set; }
        public int? LocationGroupId { get; set; }
        public int? ResignationReasonId { get; set; }
        public DateTime? ActualDoj { get; set; }
        public DateTime? ActualDob { get; set; }
    }
}
