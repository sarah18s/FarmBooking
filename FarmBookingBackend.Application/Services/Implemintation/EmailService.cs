using Microsoft.Extensions.Options;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Helper;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace FarmBookingBackend.Application.Services.Implemintation;

public class EmailService(IOptions<MailSetting> mailSettings) : IEmailService
{
    private readonly MailSetting _mailSettings = mailSettings.Value;
     
    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        MimeMessage email = new()
        {
            Subject = subject,
            From = { new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Email) },
            To = { MailboxAddress.Parse(toEmail) },
            Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            }
        };

        using var smtp = new SmtpClient();
        smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
        smtp.Authenticate(_mailSettings.Email, _mailSettings.Password);
        await smtp.SendAsync(email);

        smtp.Disconnect(true);
    }
}

