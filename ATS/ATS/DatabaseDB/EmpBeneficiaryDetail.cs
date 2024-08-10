using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EmpBeneficiaryDetail
    {
        public long Id { get; set; }
        public string? Empcode { get; set; }
        public string? BeneficiaryName { get; set; }
        public string? AccountNumber { get; set; }
        public string? ConfirmAccountNumber { get; set; }
        public string? Ifsccode { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? BankAddress { get; set; }
        public string? MobileNumber { get; set; }
        public string? ChequePath { get; set; }
        public string? Status { get; set; }
        public DateTime? RecDate { get; set; }
        public string? EncodedValue { get; set; }
    }
}
