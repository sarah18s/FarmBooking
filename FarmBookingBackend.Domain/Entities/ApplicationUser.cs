using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace FarmBookingBackend.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    [JsonIgnore]
    public ICollection<Booking>? Bookings { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}
