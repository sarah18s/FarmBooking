using Microsoft.AspNetCore.Mvc;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Web.Controllers;

[Controller]
[Route("Api/[Controller]")]
public class FarmController(IFarmService _farmService) : ControllerBase
{

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromForm] FarmModel farm)
    {
        if (!ModelState.IsValid)
        {
            return Ok(new Result { Code = 400, Error = "the Model Is Invalid" });
        }
        Result result = await _farmService.Create(farm);

        return Ok(result);
    }

    [HttpPost("Update/{id:int}")]
    public async Task<IActionResult> Update([FromForm] FarmModel farm ,int id)
    {
        if (!ModelState.IsValid)
        {
            return Ok(new Result { Code = 400, Error = "the Model Is Invalid" });
        }

        Result result =await _farmService.Update(farm , id);

        return Ok(result);
    }

    [HttpPost("Delete/{id:int}")]
    public IActionResult Delete(int id)
    {    
       Result result = _farmService.Delete(id);

        return Ok(result);
    }

    [HttpGet("GetAll")]
    public IActionResult GetAllFarms()
    {
        return Ok(_farmService.GetAll());
    }

    [HttpGet("GetById/{id:int}")]
    public IActionResult GetFarmsById(int id)
    {
        var result = _farmService.GetById(id);
        return Ok(result);
    }
    [HttpGet("GetFarmsAvailabilityByDate")]
    public IActionResult GetFarmsAvailabilityByDate([FromQuery] DateTime checkInDate )
    {
        var result = _farmService.GetFarmsAvailabilityByDate( checkInDate);
        return Ok(result);
    }



}
