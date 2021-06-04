using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Features.Dashboards.Queries.GetData;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}