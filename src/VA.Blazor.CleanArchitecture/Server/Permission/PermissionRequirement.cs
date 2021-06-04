using Microsoft.AspNetCore.Authorization;

namespace VA.Blazor.CleanArchitecture.Server.Permission
{
    internal class PermissionRequirement : IAuthorizationRequirement
    {
        public string Permission { get; private set; }

        public PermissionRequirement(string permission)
        {
            Permission = permission;
        }
    }
}