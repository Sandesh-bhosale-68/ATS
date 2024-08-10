using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblCtcbreakup
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public decimal? Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? StatutoryBonus { get; set; }
        public decimal? PfEmployeeContribution { get; set; }
        public decimal? PfEmployerContribution { get; set; }
        public decimal? EsicEmployeeContribution { get; set; }
        public decimal? EsicEmployerContribution { get; set; }
        public decimal? YearlyBasic { get; set; }
        public decimal? YearlyHra { get; set; }
        public decimal? YearlyStatutoryBonus { get; set; }
        public decimal? YearlyPfEmployeeContribution { get; set; }
        public decimal? YearlyPfEmployerContribution { get; set; }
        public decimal? YearlyEsicEmployeeContribution { get; set; }
        public decimal? YearlyEsicEmployerContribution { get; set; }
        public int? ProfessionalTaxApplied { get; set; }
        public decimal? ProfessionalTax { get; set; }
        public decimal? TotalCtcperMonth { get; set; }
        public decimal? TotalCtcperYear { get; set; }
        public decimal? YearlyProfessionalTax { get; set; }
        public decimal? NetSalaryMonth { get; set; }
        public decimal? NetSalaryYear { get; set; }
        public decimal? Conveyance { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? Gratuity { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Pli { get; set; }
        public decimal? YearlyGratuity { get; set; }
        public decimal? YearlyBonus { get; set; }
        public decimal? YearlyPli { get; set; }
        public decimal? OtherAllowanceYear { get; set; }
        public decimal? ConveyanceYear { get; set; }
    }
}
