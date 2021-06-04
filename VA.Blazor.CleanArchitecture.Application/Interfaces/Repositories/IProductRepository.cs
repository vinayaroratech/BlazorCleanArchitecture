using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}