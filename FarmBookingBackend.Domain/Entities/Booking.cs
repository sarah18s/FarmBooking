using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FarmBookingBackend.Domain.Entities;

public class Booking
{
    [JsonIgnore]
    public int Id { get; set; }
    
    public string UserId { get; set; } = null!;
    [ForeignKey("Farm")]
    public int FarmId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    public DateTime BookingDate { get; set; } = DateTime.Now;
    public double TotalCost { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Nights { get; set; }
    public DateTime PaymentDate { get; set; } = DateTime.Now;
    public string Status { get; set; } = Enum.Status.PENDING.ToString();

    [ValidateNever , ForeignKey("UserId")]
    public ApplicationUser ApplicationUser { get; set; }
    [ValidateNever]
    public Farm Farm { get; set; }
 

}



