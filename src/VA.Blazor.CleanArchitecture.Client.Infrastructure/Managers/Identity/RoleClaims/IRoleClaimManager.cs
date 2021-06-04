using System.Collections.Generic;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Requests.Identity;
using VA.Blazor.CleanArchitecture.Application.Responses.Identity;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;

namespace VA.Blazor.CleanArchitecture.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}