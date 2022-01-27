using System.Threading.Tasks;
using UzmanMetal.Api.Models;

namespace UzmanMetal.Api.Services.Email
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}