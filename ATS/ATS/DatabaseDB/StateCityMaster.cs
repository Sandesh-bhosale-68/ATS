using System;
using System.Collections.Generic;

namespace ATS.DatabaseDB
{
    public partial class StateCityMaster
    {
        public int Id { get; set; }
        public int? StateId { get; set; }
        public string? State { get; set; }
        public string? StateCode { get; set; }
        public int? CityId { get; set; }
        public string? City { get; set; }
    }
}
