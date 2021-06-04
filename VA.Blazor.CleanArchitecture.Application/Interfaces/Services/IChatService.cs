using VA.Blazor.CleanArchitecture.Application.Responses.Identity;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Chat;
using VA.Blazor.CleanArchitecture.Application.Models.Chat;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}