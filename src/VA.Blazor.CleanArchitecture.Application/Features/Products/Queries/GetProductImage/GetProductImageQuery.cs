using VA.Blazor.CleanArchitecture.Application.Interfaces.Repositories;
using VA.Blazor.CleanArchitecture.Domain.Entities.Catalog;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Application.Features.Products.Queries.GetProductImage
{
    public class GetProductImageQuery : IRequest<Result<string>>
    {
        public int Id { get; set; }

        public GetProductImageQuery(int productId)
        {
            Id = productId;
        }
    }

    internal class GetProductImageQueryHandler : IRequestHandler<GetProductImageQuery, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProductImageQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<string>> Handle(GetProductImageQuery request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.Repository<Product>().Entities.Where(p => p.Id == request.Id).Select(a => a.ImageDataURL).FirstOrDefaultAsync(cancellationToken);
            return await Result<string>.SuccessAsync(data: data);
        }
    }
}