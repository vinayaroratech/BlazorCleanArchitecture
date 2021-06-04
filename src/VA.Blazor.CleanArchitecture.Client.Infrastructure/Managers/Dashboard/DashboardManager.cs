using VA.Blazor.CleanArchitecture.Client.Infrastructure.Extensions;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Features.Dashboards.Queries.GetData;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}