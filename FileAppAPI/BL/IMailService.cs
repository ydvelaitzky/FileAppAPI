using FileAppAPI.Entities;

namespace FileAppAPI
{

    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
