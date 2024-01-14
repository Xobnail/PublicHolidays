using System.Net.Http.Json;
using PublicHolidays.Domain.Abstractions;
using PublicHolidays.Domain.Entities;

namespace PublicHolidays.Application.Services
{
    /// <summary>
    /// Service for working with Public Holiday Api.
    /// </summary>
    public class PublicHolidaysService : IPublicHolidaysService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PublicHolidaysService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Gets public holidays by year and country code.
        /// </summary>
        /// <param name="year">Year.</param>
        /// <param name="countryCode">Country code.</param>
        /// <returns>Public holidays as IAsyncEnumerable<PublicHoliday?>.</returns>
        public IAsyncEnumerable<PublicHoliday?> GetPublicHolidays(int? year, string? countryCode)
        {
            ArgumentNullException.ThrowIfNull(year, nameof(year));
            ArgumentNullException.ThrowIfNullOrEmpty(countryCode, nameof(countryCode));

            var client = _httpClientFactory.CreateClient("publicholidayapi");

            return client.GetFromJsonAsAsyncEnumerable<PublicHoliday>($"{year}/{countryCode}");
        }
    }
}
