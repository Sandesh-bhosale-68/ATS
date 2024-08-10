using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class RefAsk
    {
        public int Id { get; set; }
        public string? MobileNo { get; set; }
        public string? AlternateNo { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? Note { get; set; }
        public string? GivenBy { get; set; }
        public string? HrFeedback { get; set; }
        public string? FeedbackBy { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public string? Question1 { get; set; }
        public string? Question2 { get; set; }
        public string? Comment2 { get; set; }
        public string? Question3 { get; set; }
        public string? Comment3 { get; set; }
        public string? Question4 { get; set; }
        public string? Question5 { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
