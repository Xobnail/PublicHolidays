using PublicHolidays.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicHolidays.Domain.Abstractions
{
    public interface IPublicHolidaysService
    {
        public Task<List<PublicHoliday>> GetPublicHolidaysAsync(int year, string countryCode);
    }
}
