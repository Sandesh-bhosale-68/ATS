using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class BioLog
    {
        public decimal Id { get; set; }
        public DateTime? Sdate { get; set; }
        public string? Empcode { get; set; }
        /// <summary>
        /// 0 for in 1 for out
        /// </summary>
        public byte? Stype { get; set; }
        /// <summary>
        /// system name or IP
        /// </summary>
        public string? Sysname { get; set; }
        /// <summary>
        /// 0 for biometric 1 for password
        /// </summary>
        public byte? Smode { get; set; }
        /// <summary>
        /// 0 for failed 1 for success
        /// </summary>
        public byte? Sstatus { get; set; }
        public string? Comments { get; set; }
        /// <summary>
        /// Approving HR Employee
        /// </summary>
        public string? Hrempcode { get; set; }
        /// <summary>
        /// Approving HR system
        /// </summary>
        public string? Hrsystem { get; set; }
        /// <summary>
        /// 1 for Mumbai, 2 for Delhi, 3 for Indore,4 for LG, 5 for Gurgaon, 6 for Banglore, 20 for Other
        /// </summary>
        public byte? Location { get; set; }
    }
}
