using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class OutdoorCompaignDetail
    {
        public long CampaignId { get; set; }
        public long UniqueRefNo { get; set; }
        public string? Name { get; set; }
        public DateTime? Dob { get; set; }
        public string? Sex { get; set; }
        public string? ContactNo { get; set; }
        public string? AlternateNo { get; set; }
        public string? EmailId { get; set; }
        public string? HighQualification { get; set; }
        public string? LanguagesKnown { get; set; }
        public string? Location { get; set; }
        public string? AadharNumber { get; set; }
        public string? Pannumber { get; set; }
        public bool? IsSmssent { get; set; }
        public string? Response { get; set; }
        public DateTime? RecDate { get; set; }
        public string? UploadedCvpath { get; set; }
    }
}
