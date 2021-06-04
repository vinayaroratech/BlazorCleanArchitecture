using AutoMapper;
using VA.Blazor.CleanArchitecture.Infrastructure.Models.Identity;
using VA.Blazor.CleanArchitecture.Application.Responses.Identity;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}