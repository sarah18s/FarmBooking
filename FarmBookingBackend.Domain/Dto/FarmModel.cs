using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Domain.Dto;

public class FarmModel
{
   
    public string? Name { get; set; } = null;
    public string? Description { get; set; } = null;
   
    public double Price { get; set; } =0;
    public int Sqft { get; set; } = 0;
    
    public int Occupancy { get; set; } = 0;

    public string ImageUrl { get; set; }

    public IFormFile? Image { get; set; }
}
