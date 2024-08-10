using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TraningAtt
    {
        public int Id { get; set; }
        public int? Masterid { get; set; }
        public string? AgentName { get; set; }
        public DateTime? AttDate { get; set; }
        public string? AttStatus { get; set; }
        public string? AttComments { get; set; }
        public string? UpdatedBy { get; set; }
        public string? BatchId { get; set; }
    }
}
