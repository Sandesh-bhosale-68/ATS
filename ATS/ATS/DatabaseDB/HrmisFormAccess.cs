﻿using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HrmisFormAccess
    {
        public decimal Code { get; set; }
        public string? UserName { get; set; }
        public decimal? AccessNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}