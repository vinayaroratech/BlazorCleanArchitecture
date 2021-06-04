using VA.Blazor.CleanArchitecture.Application.Interfaces.Repositories;
using VA.Blazor.CleanArchitecture.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepositoryAsync<Product> _repository;

        public ProductRepository(IRepositoryAsync<Product> repository)
        {
            _repository = repository;
        }

        public async Task<bool> IsBrandUsed(int brandId)
        {
            return await _repository.Entities.AnyAsync(b => b.BrandId == brandId);
        }
    }
}