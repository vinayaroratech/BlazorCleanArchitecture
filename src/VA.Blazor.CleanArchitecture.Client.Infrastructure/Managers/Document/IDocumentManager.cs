using VA.Blazor.CleanArchitecture.Application.Features.Documents.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Application.Features.Documents.Queries.GetAll;
using VA.Blazor.CleanArchitecture.Application.Requests.Documents;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}