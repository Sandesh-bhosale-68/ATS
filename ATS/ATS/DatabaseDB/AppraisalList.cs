using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class AppraisalList
    {
        public AppraisalList()
        {
            Rewards = new HashSet<Reward>();
        }

        public int Id { get; set; }
        public string? AppraisalType { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<Reward> Rewards { get; set; }
    }
}
