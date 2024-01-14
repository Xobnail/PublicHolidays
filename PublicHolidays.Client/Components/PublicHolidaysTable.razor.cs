using Microsoft.AspNetCore.Components;
using PublicHolidays.Domain.Entities;
using PublicHolidays.Domain.Abstractions;
using Microsoft.AspNetCore.Components.Web;

namespace PublicHolidays.Client.Components
{
    public partial class PublicHolidaysTable
    {
        [Inject]
        public IPublicHolidaysService? PublicHolidayService {  get; set; }
        public List<PublicHoliday>? PublicHolidays { get; set; }

        /// <summary>
        /// Year from which get holidays data.
        /// </summary>
        [Parameter]
        public int Year { get; set; }

        /// <summary>
        /// Country from which get holidays data.
        /// </summary>
        [Parameter]
        public string? Country { get; set; }

        /// <summary>
        /// Fills table with public holidays data.
        /// </summary>
        protected override async Task OnParametersSetAsync()
        {
            PublicHolidays = new List<PublicHoliday>();

            try
            {
                await foreach (var holiday in PublicHolidayService!.GetPublicHolidays(Year, Country))
                {
                    PublicHolidays.Add(holiday!);
                    StateHasChanged();
                }
            }
            catch
            {
                throw new Exception("Can not load public holidays data.");
            }
        }
    }
}