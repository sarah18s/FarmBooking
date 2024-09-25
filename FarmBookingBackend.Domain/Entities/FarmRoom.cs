using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FarmBookingBackend.Domain.Entities;

public class FarmRoom
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Display(Name = "FarmRoom Number")]
    public int FarmRoom_Number { get; set; }
    [ForeignKey("Farm")]
    public int FarmId { get; set; }
    [ValidateNever , JsonIgnore]
    public Farm Farm { get; set; }
    public string SpecialDetails { get; set; }
    [JsonIgnore]
    public DateTime Created_Date { get; set; } = DateTime.Now;
    [JsonIgnore]
    public DateTime? Updated_Date { get; set; }

}
