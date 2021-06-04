using VA.Blazor.CleanArchitecture.Application.Features.Products.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Application.Features.Products.Queries.GetAllPaged;
using VA.Blazor.CleanArchitecture.Application.Requests.Catalog;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<string> ExportToExcelAsync(string searchString = "");
    }
}