using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicHolidays.Domain.Abstractions;
using PublicHolidays.Domain.Entities;

namespace PublicHolidays.Application.Services
{
    internal class PublicHolidaysService : IPublicHolidaysService
    {
        public async Task<List<PublicHoliday>> GetPublicHolidaysAsync(int year, string countryCode)
        {
            throw new NotImplementedException();
        }
    }
}
