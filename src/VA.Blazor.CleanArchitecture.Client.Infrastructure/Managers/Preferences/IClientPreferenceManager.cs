using VA.Blazor.CleanArchitecture.Shared.Managers;
using MudBlazor;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}