using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FarmBookingBackend.Web.Controllers;

[Controller]
[Route("Api/[Controller]")]
public class AmenityController(IAmenityService _amenityService) : ControllerBase
{
    [HttpPost("Create")]
    public IActionResult CreateAmenity([FromBody] Amenity amenity)
    {
        if (!ModelState.IsValid)
        {
            return Ok(new Result { Code = 400, Error = "the Model Is Invalid" });
        }
        Result result = _amenityService.Create(amenity);
        return Ok(result);
    }

    [HttpPost("Delete/{Id:int}")]
    public IActionResult DeleteAmenity(int Id)
    {
        var result = _amenityService.Delete(Id);
        return Ok(result);
    }

    [HttpPost("Update")]
    public IActionResult UpdateAmenity([FromBody] AmenityDto amenityDto)
    {
        if (!ModelState.IsValid)
        {
            return Ok(new Result { Code = 400, Error = "the Model Is Invalid" });
        }
        Result result = _amenityService.Update(amenityDto);
        return Ok(result);
    }

    [HttpGet("GetById/{Id:int}")]
    public IActionResult GetAmenityById( int Id)
    {
        var result = _amenityService.GetById(Id);
        return Ok(result);
    }

    [HttpGet("GetAll/{farmId:int}")]
    public IActionResult GetAll(int farmId)
    {
        var result = _amenityService.GetAll(farmId);
        return Ok(result);
    }
}
