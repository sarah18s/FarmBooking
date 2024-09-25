using Microsoft.AspNetCore.Mvc;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Web.Controllers;

[Controller]
[Route("Api/[Controller]")]
public class FarmRoomController(IFarmRoomService farmRoomService): ControllerBase
{
    private readonly IFarmRoomService _farmRoomService = farmRoomService;

    [HttpPost("Create")]
    public IActionResult CreateRoom([FromBody] FarmRoom farmRoom)
    {
        if (!ModelState.IsValid)
        {
            return Ok(new Result { Code = 400, Error = "the Model Is Invalid" });
        }
        Result result = _farmRoomService.Create(farmRoom);
        return Ok(result);
    }

    [HttpPost("Update")]
    public IActionResult UpdateRoom([FromBody] FarmRoom farm)
    {
        if (!ModelState.IsValid)
        {
            return Ok(new Result { Code = 400, Error = "the Model Is Invalid" });
        }
        Result result = _farmRoomService.Update(farm);
        return Ok(result);
    }

    [HttpGet("GetById/{Id:int}")]
    public IActionResult GetFarmRoomById(int Id)
    {
        var result = _farmRoomService.GetById(Id);
        return Ok(result);
    }

    [HttpGet("GetAll/{farmId:int}")]
    public IActionResult GetAllFarmRoom(int farmId)
    {
        var result = _farmRoomService.GetAll(farmId);
        return Ok(result);
    }
}
