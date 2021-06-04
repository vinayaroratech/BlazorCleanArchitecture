using VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.GetAll;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Commands.AddEdit;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<string> ExportToExcelAsync(string searchString = "");
    }
}