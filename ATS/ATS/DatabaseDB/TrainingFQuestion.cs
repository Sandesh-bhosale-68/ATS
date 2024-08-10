using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TrainingFQuestion
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? Type { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
