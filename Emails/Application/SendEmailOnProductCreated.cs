using Emails.Infrastructure;
using MassTransit;

namespace Emails.Application
{
    public class SendEmailOnProductCreated : IConsumer<ProductCreated>
    {
        private readonly IEmailSender emailSender;

        public SendEmailOnProductCreated(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public Task Consume(ConsumeContext<ProductCreated> context)
        {
            return emailSender.Send(
                "consumer@mail.com",
                "Product Created",
                $"Product with name: {context.Message.Name} and id: {context.Message.Id:N} created.");
        }
    }
}