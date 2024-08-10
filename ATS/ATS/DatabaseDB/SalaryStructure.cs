using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SalaryStructure
    {
        public string? MasterId { get; set; }
        public int Id { get; set; }
        public string EmpCode { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? Cca { get; set; }
        public decimal? Conveyance { get; set; }
        public decimal? StBonus { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? VAllowance { get; set; }
        public decimal? GrossSalaryA { get; set; }
        public decimal? Sodexho { get; set; }
        public decimal? Medical { get; set; }
        public decimal? Education { get; set; }
        public decimal? Lta { get; set; }
        public decimal? TotalAllowancesB { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? EmployeePf { get; set; }
        public decimal? Ptax { get; set; }
        public decimal? EmployeeEsic { get; set; }
        public decimal? IncomeTax { get; set; }
        public decimal? TotalDeduction { get; set; }
        public decimal? NetSalary { get; set; }
        public decimal? Gratuity { get; set; }
        public decimal? EmployerPf { get; set; }
        public decimal? EmployerEsic { get; set; }
        public decimal? TotalContribution { get; set; }
        public decimal? Ctc { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public int? LocationId { get; set; }
        public string? Systemname { get; set; }
    }
}
