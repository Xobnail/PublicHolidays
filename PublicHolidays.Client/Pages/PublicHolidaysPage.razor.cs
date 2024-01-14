using Microsoft.AspNetCore.Components;
using PublicHolidays.Domain.Abstractions;

namespace PublicHolidays.Client.Pages
{
    public partial class PublicHolidaysPage
    {
        [Inject]
        public IPublicHolidaysService? PublicHolidayService { get; set; }
        public int CurrentYear { get; set; } = 2023;
        public string? CurrentCountry { get; set; } = "RU";

        /// <summary>
        /// Apply selected year.
        /// </summary>
        /// <param name="year">A year to apply.</param>
        public void SelectYear(int year)
        {
            CurrentYear = year;
            StateHasChanged();
        }

        /// <summary>
        /// Apply selected country.
        /// </summary>
        /// <param name="country">A country to apply.</param>
        public void SelectCountry(string country)
        {
            CurrentCountry = country;
            StateHasChanged();
        }
    }
}