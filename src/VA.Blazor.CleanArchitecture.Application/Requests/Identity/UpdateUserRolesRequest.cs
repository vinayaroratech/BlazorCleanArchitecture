using VA.Blazor.CleanArchitecture.Application.Responses.Identity;
using System.Collections.Generic;

namespace VA.Blazor.CleanArchitecture.Application.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public IList<UserRoleModel> UserRoles { get; set; }
    }
}