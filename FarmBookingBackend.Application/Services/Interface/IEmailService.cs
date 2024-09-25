namespace FarmBookingBackend.Application.Services.Interface
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string message);
        
    }
}
