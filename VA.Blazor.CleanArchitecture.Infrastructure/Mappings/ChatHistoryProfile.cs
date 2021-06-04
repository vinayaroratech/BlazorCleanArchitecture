using AutoMapper;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Chat;
using VA.Blazor.CleanArchitecture.Application.Models.Chat;
using VA.Blazor.CleanArchitecture.Infrastructure.Models.Identity;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}