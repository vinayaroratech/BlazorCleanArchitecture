using VA.Blazor.CleanArchitecture.Application.Features.Products.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Application.Features.Products.Queries.GetAllPaged;
using VA.Blazor.CleanArchitecture.Application.Requests.Catalog;
using VA.Blazor.CleanArchitecture.Client.Infrastructure.Extensions;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Catalog.Product
{
    public class ProductManager : IProductManager
    {
        private readonly HttpClient _httpClient;

        public ProductManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.ProductsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<string> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.ProductsEndpoints.Export
                : Routes.ProductsEndpoints.ExportFiltered(searchString));
            var data = await response.Content.ReadAsStringAsync();
            return data;
        }

        public async Task<IResult<string>> GetProductImageAsync(int id)
        {
            var response = await _httpClient.GetAsync(Routes.ProductsEndpoints.GetProductImage(id));
            return await response.ToResult<string>();
        }

        public async Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request)
        {
            var response = await _httpClient.GetAsync(Routes.ProductsEndpoints.GetAllPaged(request.PageNumber, request.PageSize));
            return await response.ToPaginatedResult<GetAllPagedProductsResponse>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditProductCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.ProductsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}