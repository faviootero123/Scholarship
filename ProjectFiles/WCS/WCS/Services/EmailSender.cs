using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WCS.Data;
using WCS.Models;

namespace WCS.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        private EmailSettings _settings;
        private readonly WcsContext _context;

        public EmailSender(WcsContext context)
        {
            _context = context;
            _settings = Assistant.GetEmailSettings(context);
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var smtpClient = new SmtpClient
            {
                Host = _settings.Host, // set your SMTP server name here
                Port = _settings.Port, // Port 
                EnableSsl = _settings.EnableSSL,
                UseDefaultCredentials = _settings.UseDefaultCredentials,
                Credentials = new NetworkCredential(_settings.UserName, _settings.DecryptedPassword)
            };

            using var emailMessage = new MailMessage(_settings.SenderName, email)
            {
                Subject = subject,
                Body = message
            };
            try
            {
                emailMessage.IsBodyHtml = true;
                await smtpClient.SendMailAsync(emailMessage);
            }
            catch (Exception ex)
            {
                _context.Settings.Add(new Setting()
                {
                    SettingName = DateTime.Now.ToString() + " Email Exception",
                    SettingValue = ex.ToString()
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
