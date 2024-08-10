using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class MomAnswerMaster
    {
        public int Id { get; set; }
        public int QId { get; set; }
        public int? AnsId { get; set; }
        public string? AnsName { get; set; }
    }
}
