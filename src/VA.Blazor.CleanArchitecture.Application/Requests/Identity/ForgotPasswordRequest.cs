using System.ComponentModel.DataAnnotations;

namespace VA.Blazor.CleanArchitecture.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}