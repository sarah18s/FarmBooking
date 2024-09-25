using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FarmBookingBackend.Domain.Entities;

public class Amenity
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    [ForeignKey("Farm")]
    public int FarmId {  get; set; }
    [JsonIgnore , ValidateNever]
    public Farm Farm { get; set; }
    [JsonIgnore]
    public bool IsAvailable { get; set; } = true;
    [JsonIgnore]
    public bool IsDelete { get; set; } = false;
    [JsonIgnore]
    public DateTime Created_Date { get; set; } = DateTime.Now;
    [JsonIgnore]
    public DateTime? Updated_Date { get; set; }
}
