﻿using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class HolidayList
    {
        public int Sr { get; set; }
        public string? Holiday { get; set; }
        public DateTime? Date { get; set; }
        public string? Location { get; set; }
    }
}