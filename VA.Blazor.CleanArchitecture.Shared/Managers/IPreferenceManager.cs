using VA.Blazor.CleanArchitecture.Shared.Settings;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;

namespace VA.Blazor.CleanArchitecture.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}