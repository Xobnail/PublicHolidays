using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using PublicHolidays.Domain.Abstractions;
using PublicHolidays.Domain.Entities;

namespace PublicHolidays.Application.Services
{
    internal class PublicHolidaysService : IPublicHolidaysService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PublicHolidaysService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<PublicHoliday>?> GetPublicHolidaysAsync(int? year, string? countryCode)
        {
            ArgumentNullException.ThrowIfNull(year, nameof(year));
            ArgumentNullException.ThrowIfNullOrEmpty(countryCode, nameof(countryCode));

            var client = _httpClientFactory.CreateClient("publicholidayapi");

            return await client.GetFromJsonAsync<List<PublicHoliday>>($"{year}/{countryCode}");
        }
    }
}
