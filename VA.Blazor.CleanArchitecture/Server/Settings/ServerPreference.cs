using System.Linq;
using VA.Blazor.CleanArchitecture.Shared.Constants.Localization;
using VA.Blazor.CleanArchitecture.Shared.Settings;

namespace VA.Blazor.CleanArchitecture.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}