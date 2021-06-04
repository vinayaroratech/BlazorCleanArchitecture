using AutoMapper;
using VA.Blazor.CleanArchitecture.Infrastructure.Models.Audit;
using VA.Blazor.CleanArchitecture.Application.Responses.Audit;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}