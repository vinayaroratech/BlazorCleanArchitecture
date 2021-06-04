using VA.Blazor.CleanArchitecture.Application.Responses.Audit;
using VA.Blazor.CleanArchitecture.Client.Infrastructure.Extensions;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Audit
{
    public class AuditManager : IAuditManager
    {
        private readonly HttpClient _httpClient;

        public AuditManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync()
        {
            var response = await _httpClient.GetAsync(Routes.AuditEndpoints.GetCurrentUserTrails);
            var data = await response.ToResult<IEnumerable<AuditResponse>>();
            return data;
        }

        public async Task<string> DownloadFileAsync(string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false)
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.AuditEndpoints.DownloadFile
                : Routes.AuditEndpoints.DownloadFileFiltered(searchString, searchInOldValues, searchInNewValues));
            var data = await response.Content.ReadAsStringAsync();
            return data;
        }
    }
}