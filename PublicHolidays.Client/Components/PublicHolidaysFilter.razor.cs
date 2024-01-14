using Microsoft.AspNetCore.Components;

namespace PublicHolidays.Client.Components
{
    public partial class PublicHolidaysFilter
    {
        [Parameter, EditorRequired]
        public int CurrentYear { get; set; }
        [Parameter, EditorRequired]
        public string? CurrentCountry { get; set; }
        [Parameter]
        public Action<int>? OnYearSelected { get; set; }
        [Parameter]
        public Action<string>? OnCountrySelected { get; set; }
    }
}