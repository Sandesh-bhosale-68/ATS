using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATS.DatabaseDB
{
    public partial class TblCandidateDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public int? MasterId { get; set; }
        public string? ImageName { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
