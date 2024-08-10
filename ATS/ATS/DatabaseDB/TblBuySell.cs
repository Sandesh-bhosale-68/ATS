using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class TblBuySell
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public long? ContactNo { get; set; }
        public string? ProductInfo { get; set; }
        /// <summary>
        /// 1 = Buyer, 2 = Seller
        /// </summary>
        public int? ActionType { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
