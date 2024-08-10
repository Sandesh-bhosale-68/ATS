using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RecrDocumentsHistory
    {
        public int Id { get; set; }
        public decimal? MasterId { get; set; }
        public string? Ssc { get; set; }
        public string? Hsc { get; set; }
        public string? Graduation { get; set; }
        public string? Pg { get; set; }
        public string? OtherEdu { get; set; }
        public string? PanCard { get; set; }
        public string? VoterId { get; set; }
        public string? DrivingLicenceId { get; set; }
        public string? PassportId { get; set; }
        public string? OtherIdProof { get; set; }
        public string? RationCard { get; set; }
        public string? ElecticityBill { get; set; }
        public string? DrivingLicenceAdd { get; set; }
        public string? PasswordAdd { get; set; }
        public string? OtherAddProof { get; set; }
        public string? SalarySlip { get; set; }
        public string? BankStatements { get; set; }
        public string? ApptLetter { get; set; }
        public string? IncrementLetter { get; set; }
        public string? OtherIncomeProof { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
