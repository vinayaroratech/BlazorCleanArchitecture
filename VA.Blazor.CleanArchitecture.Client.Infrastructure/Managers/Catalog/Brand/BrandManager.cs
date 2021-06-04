using VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.GetAll;
using VA.Blazor.CleanArchitecture.Client.Infrastructure.Extensions;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Commands.AddEdit;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Catalog.Brand
{
    public class BrandManager : IBrandManager
    {
        private readonly HttpClient _httpClient;

        public BrandManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.BrandsEndpoints.Export
                : Routes.BrandsEndpoints.ExportFiltered(searchString));
            var data = await response.Content.ReadAsStringAsync();
            return data;
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.BrandsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.BrandsEndpoints.GetAll);
            return await response.ToResult<List<GetAllBrandsResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditBrandCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.BrandsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}