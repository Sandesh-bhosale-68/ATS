using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SalaryAnnexureLog
    {
        public int? Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? OfferCtc { get; set; }
        public int? LocationId { get; set; }
        public string? Gender { get; set; }
        public string? PfStatus { get; set; }
        public string? SodexhoStatus { get; set; }
        public string? MedicalStatus { get; set; }
        public string? MobileStatus { get; set; }
        public byte[]? GrossSalary { get; set; }
        public byte[]? Basic { get; set; }
        public byte[]? Hra { get; set; }
        public decimal? Cca { get; set; }
        public decimal? Conveyance { get; set; }
        public byte[]? StBonus { get; set; }
        public byte[]? OtherAllowance { get; set; }
        public decimal? VAllowance { get; set; }
        public decimal? GrossSalaryA { get; set; }
        public decimal? SodexhoPm { get; set; }
        public decimal? MedicalPm { get; set; }
        public decimal? EducationPm { get; set; }
        public decimal? LtaPm { get; set; }
        public decimal? PetrolPm { get; set; }
        public decimal? MobilePm { get; set; }
        public decimal? TotalAllowancesPm { get; set; }
        public decimal? GrossPm { get; set; }
        public decimal? EmployeePfPm { get; set; }
        public decimal? Ptax { get; set; }
        public decimal? EmployeeEsic { get; set; }
        public string? IncomeTax { get; set; }
        public byte[]? TotalDeduction { get; set; }
        public byte[]? NetSalary { get; set; }
        public decimal? Gratuity { get; set; }
        public decimal? EmployerPf { get; set; }
        public decimal? EmployerEsic { get; set; }
        public decimal? EmplDeduction { get; set; }
        public byte[]? Pli { get; set; }
        public decimal? AnnualBonus { get; set; }
        public byte[]? TotalCtc { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public string? Systemname { get; set; }
        public byte[]? AnnualStBonus { get; set; }
        public string? Designation { get; set; }
        public byte[]? RetentionBonus { get; set; }
        public string? Remark1 { get; set; }
        public string? Remark2 { get; set; }
    }
}
