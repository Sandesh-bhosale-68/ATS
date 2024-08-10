using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class EssEmpFeedback
    {
        public int EssEmpFbId { get; set; }
        public string? EssEmpCode { get; set; }
        public string? EssEmpName { get; set; }
        public string? EssEmpDesignation { get; set; }
        public string? EssEmpLocation { get; set; }
        public string? EssEmpMessage { get; set; }
        public DateTime? EssEmpDate { get; set; }
        public string? EssEmpEmail { get; set; }
    }
}
