using System.ComponentModel.DataAnnotations;

namespace FarmBookingBackend.Domain.Dto;

public class MailRequestModel
{
    [Required]
    public string ToEmail { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string Message { get; set; }
}
