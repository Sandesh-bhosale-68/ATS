using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HoroscopeMaster
    {
        public int Id { get; set; }
        public string? Pleo { get; set; }
        public string? Paries { get; set; }
        public string? Ptaurus { get; set; }
        public string? Pgemini { get; set; }
        public string? Pcancer { get; set; }
        public string? Pvirgo { get; set; }
        public string? Plibra { get; set; }
        public string? Psagittarius { get; set; }
        public string? Pcapricorn { get; set; }
        public string? Paquarius { get; set; }
        public string? Ppisces { get; set; }
        public string? Pscorpio { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
