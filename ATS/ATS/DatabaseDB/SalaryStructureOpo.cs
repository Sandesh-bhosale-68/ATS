using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SalaryStructureOpo
    {
        public int Id { get; set; }
        public string? MasterId { get; set; }
        public string? Empcode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? Cca { get; set; }
        public decimal? Conveyance { get; set; }
        public decimal? StBonus { get; set; }
        public decimal? AttendanceAllowance { get; set; }
        public decimal? VariableAllowance { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? Food { get; set; }
        public decimal? Medical { get; set; }
        public decimal? Education { get; set; }
        public decimal? Mobile { get; set; }
        public decimal? Petrol { get; set; }
        public decimal? Sodexho { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal? EmployerPf { get; set; }
        public decimal? EmployerEsic { get; set; }
        public decimal? Gratuity { get; set; }
        public decimal? GrossCtc { get; set; }
        public decimal? Pli { get; set; }
        public decimal? NetEarning { get; set; }
        public decimal? Esic { get; set; }
        public decimal? Pf { get; set; }
        public decimal? ProfessionalTax { get; set; }
        public decimal? NetTakeHome { get; set; }
        public decimal? TotalDeductions { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public int? LocationId { get; set; }
        public string? Systemname { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalCtc { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
