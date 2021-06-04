using VA.Blazor.CleanArchitecture.Application.Features.Documents.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Application.Features.Documents.Queries.GetAll;
using VA.Blazor.CleanArchitecture.Application.Requests.Documents;
using VA.Blazor.CleanArchitecture.Client.Infrastructure.Extensions;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Document
{
    public class DocumentManager : IDocumentManager
    {
        private readonly HttpClient _httpClient;

        public DocumentManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.DocumentsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request)
        {
            var response = await _httpClient.GetAsync(Routes.DocumentsEndpoints.GetAllPaged(request.PageNumber, request.PageSize));
            return await response.ToPaginatedResult<GetAllDocumentsResponse>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditDocumentCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.DocumentsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}