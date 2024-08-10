using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATS.DatabaseDB
{
    public partial class ExperienceDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long? MasterId { get; set; }
        public string? MobileNo { get; set; }
        public string? CompanyName { get; set; }
        public string? Designation { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? TotalExperience { get; set; }
        public string? Process { get; set; }
        public string? Ctc { get; set; }
        public DateTime? RecDate { get; set; }
    }
}
