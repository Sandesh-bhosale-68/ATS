using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class SrvQuestionMaster
    {
        public long QId { get; set; }
        public long SrvId { get; set; }
        public long? ThemeId { get; set; }
        public int QSrNo { get; set; }
        public string? QName { get; set; }
        public string? QType { get; set; }
        public string? QValue { get; set; }
        public string? AnsValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
