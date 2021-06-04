using System.Collections.Generic;

namespace VA.Blazor.CleanArchitecture.Application.Responses.Identity
{
    public class GetAllUsersResponse
    {
        public IEnumerable<UserResponse> Users { get; set; }
    }
}