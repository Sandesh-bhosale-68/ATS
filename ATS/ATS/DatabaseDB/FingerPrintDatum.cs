using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class FingerPrintDatum
    {
        public int Id { get; set; }
        public string EmpId { get; set; } = null!;
        public string? Firtext { get; set; }
        public string? Firbinary { get; set; }
        public string? RegistrationBy { get; set; }
        public string? RegType { get; set; }
        public string? RegistrationMachine { get; set; }
        public DateTime? RegistrationTime { get; set; }
        public string? RegPassword { get; set; }
        public int? MasterId { get; set; }
    }
}
