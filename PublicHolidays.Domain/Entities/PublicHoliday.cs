using PublicHolidays.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicHolidays.Domain.Entities
{
    public class PublicHoliday
    {
        public DateTime Date { get; set; }
        public string? LocalName { get; set; }
        public string? Name { get; set; }
        public string? CountryCode { get; set; }
        public bool Fixed { get; set; }
        public bool Global { get; set; }
        public List<string>? Countries { get; set; }
        public int? LaunchYear { get; set; }
        public List<string>? Types { get; set; }
    }
}
