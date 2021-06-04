using System.ComponentModel.DataAnnotations;

namespace VA.Blazor.CleanArchitecture.Application.Requests.Identity
{
    public class RoleRequest
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}