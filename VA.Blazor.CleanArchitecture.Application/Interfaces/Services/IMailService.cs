using VA.Blazor.CleanArchitecture.Application.Requests.Mail;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}