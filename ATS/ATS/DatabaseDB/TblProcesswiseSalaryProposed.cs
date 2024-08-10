using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblProcesswiseSalaryProposed
    {
        public int Id { get; set; }
        public string? ProcessName { get; set; }
        public int? LocationId { get; set; }
        public string? LocationName { get; set; }
        public decimal? ProposedMonthlyCtc { get; set; }
        public decimal? ProposedNetCtcperMonth { get; set; }
        public decimal? ProposedYearlyCtc { get; set; }
    }
}
