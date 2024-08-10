using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RollUserMaster
    {
        public int RollUserId { get; set; }
        public int? UserId { get; set; }
        public int? RollId { get; set; }
        public string? FormId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Deleted { get; set; }
    }
}
