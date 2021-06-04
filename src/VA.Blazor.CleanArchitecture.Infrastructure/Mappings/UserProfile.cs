using AutoMapper;
using VA.Blazor.CleanArchitecture.Infrastructure.Models.Identity;
using VA.Blazor.CleanArchitecture.Application.Responses.Identity;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, BlazorHeroUser>().ReverseMap();
            CreateMap<ChatUserResponse, BlazorHeroUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}