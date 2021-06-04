using VA.Blazor.CleanArchitecture.Application.Models.Chat;
using VA.Blazor.CleanArchitecture.Application.Responses.Identity;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Chat;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}