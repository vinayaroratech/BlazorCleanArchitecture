using System.Linq;
using VA.Blazor.CleanArchitecture.Shared.Constants.Localization;
using VA.Blazor.CleanArchitecture.Shared.Settings;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Settings
{
    public record ClientPreference : IPreference
    {
        public bool IsDarkMode { get; set; }
        public bool IsRTL { get; set; }
        public bool IsDrawerOpen { get; set; }
        public string PrimaryColor { get; set; }
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";
    }
}