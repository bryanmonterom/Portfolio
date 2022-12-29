using Portfolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portfolio.Services
{
    public interface IEmailSendGrid
    {
        Task SendEmailAsync(ContactViewModel contact);
    }
    public class EmailSendGrid : IEmailSendGrid
    {
        private readonly IConfiguration _configuration;
        public EmailSendGrid(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task SendEmailAsync(ContactViewModel contact) {

            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = _configuration.GetValue<string>("SENDGRID_NAME");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email);
            var subject = $"The client {contact.Name} want's to contact you";
            var to = new EmailAddress(email, nombre);
            var plainText = contact.Message;
            var htmlBody = @$"From: {contact.Name } - 
            Email: {contact.Email}
            Mensaje: {contact.Message}";

            var singleEmail = MailHelper.CreateSingleEmail(from, to, 
                                        subject, plainText, htmlBody);

            var response = await client.SendEmailAsync(singleEmail);


        }
    }
}
