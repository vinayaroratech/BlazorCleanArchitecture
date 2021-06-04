using System.Collections.Generic;

namespace VA.Blazor.CleanArchitecture.Application.Responses.Identity
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}