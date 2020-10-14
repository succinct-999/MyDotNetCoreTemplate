using System.Threading.Tasks;

namespace MyDotNetCoreTemplate.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}