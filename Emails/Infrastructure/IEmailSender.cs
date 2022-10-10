namespace Emails.Infrastructure
{
    public interface IEmailSender
    {
        Task Send(string to, string subject, string body);
    }
}
