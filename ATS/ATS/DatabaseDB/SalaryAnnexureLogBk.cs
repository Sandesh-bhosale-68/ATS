using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SalaryAnnexureLogBk
    {
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
        public decimal? GrossSalary { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? Cca { get; set; }
        public decimal? Conveyance { get; set; }
        public decimal? StBonus { get; set; }
        public decimal? OtherAllowance { get; set; }
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
        public decimal? TotalDeduction { get; set; }
        public decimal? NetSalary { get; set; }
        public decimal? Gratuity { get; set; }
        public decimal? EmployerPf { get; set; }
        public decimal? EmployerEsic { get; set; }
        public decimal? EmplDeduction { get; set; }
        public decimal? Pli { get; set; }
        public decimal? AnnualBonus { get; set; }
        public decimal? TotalCtc { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public string? Systemname { get; set; }
    }
}
