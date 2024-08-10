using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class AttBackup
    {
        public decimal Id { get; set; }
        public string Empcode { get; set; } = null!;
        public string AttDate { get; set; } = null!;
        public string? AttStatus { get; set; }
        public string? AttCode { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public string? AttComments { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? UpdateEmpcode { get; set; }
    }
}
