using VA.Blazor.CleanArchitecture.Application.Interfaces.Common;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}