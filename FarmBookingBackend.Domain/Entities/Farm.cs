using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FarmBookingBackend.Domain.Entities;

public class Farm
{
    public int Id { get; set; }
    [MaxLength(50)]
    public required string Name { get; set; }
    public string? Description { get; set; }
    [Display(Name = "Price each night")]
    [Range(10, 10000)]
    public double Price { get; set; }
    public int Sqft { get; set; }
    [Range(1, 10)]
    public int Occupancy { get; set; }
    [NotMapped, JsonIgnore, ValidateNever]
    public IFormFile? Image { get; set; }
    [Display(Name = "Image Url")]
    public string? ImageUrl { get; set; }
    public DateTime Created_Date { get; set; } = DateTime.Now;
    public DateTime? Updated_Date { get; set; }
    [ValidateNever]
    public ICollection<Amenity>? Amenities { get; set; }
    [ValidateNever]
    public Booking? Booking { get; set; }
    [ValidateNever]
    public ICollection<FarmRoom>? FarmRooms { get; set; }
    public bool IsAvailable { get; set; } = true;
    public bool IsDelete { get; set; } = false;
}