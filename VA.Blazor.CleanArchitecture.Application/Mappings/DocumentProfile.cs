using AutoMapper;
using VA.Blazor.CleanArchitecture.Application.Features.Documents.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Domain.Entities;

namespace VA.Blazor.CleanArchitecture.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, DocumentFile>().ReverseMap();
        }
    }
}