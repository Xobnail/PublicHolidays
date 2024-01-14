using PublicHolidays.Domain.Entities;

namespace PublicHolidays.Domain.Abstractions
{
    /// <summary>
    /// Interface for working with Public Holiday Api.
    /// </summary>
    public interface IPublicHolidaysService
    {
        /// <summary>
        /// Gets public holidays by year and country code.
        /// </summary>
        /// <param name="year">Year.</param>
        /// <param name="countryCode">Country code.</param>
        /// <returns>Public holidays as IAsyncEnumerable<PublicHoliday?>.</returns>
        public IAsyncEnumerable<PublicHoliday?> GetPublicHolidays(int? year, string? countryCode);
    }
}
