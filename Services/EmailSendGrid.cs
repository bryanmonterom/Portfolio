using Portfolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Mail;

namespace Portfolio.Services
{
    public interface IEmailSendGrid
    {
        void SendEmailAsync(ContactViewModel contact);
    }
    public class EmailSendGrid : IEmailSendGrid
    {
        private readonly IConfiguration _configuration;
        public EmailSendGrid(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public  void SendEmailAsync(ContactViewModel contact) {

            var email = _configuration.GetValue<string>("EMAIL_FROM");
            var password = _configuration.GetValue<string>("EMAIL_PASSWORD");
            var to = _configuration.GetValue<string>("EMAIL_TO");


            var from = new EmailAddress(email);
            var subject = $"The client {contact.Name} want's to contact you";
            var plainText = contact.Message;
            var htmlBody = @$"From: {contact.Name } - 
            Email: {contact.Email}
            Mensaje: {contact.Message}";


            try
            {
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(email),
                    Subject = subject,
                    IsBodyHtml = true,
                    Body = htmlBody
                };
                mail.To.Add(to);
                SmtpClient smtpClient = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    Timeout = Int32.MaxValue,
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(email, password)
                };
                smtpClient.Send(mail);

            }
            catch (Exception ex)
            {

                throw;
            }
           


        }
    }
}
