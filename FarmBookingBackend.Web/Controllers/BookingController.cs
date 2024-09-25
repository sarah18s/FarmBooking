using Microsoft.AspNetCore.Mvc;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Web.Controllers;

[Controller]
[Route("Api/[Controller]")]
public class BookingController(IBookingService bookingService) : ControllerBase
{
    private readonly IBookingService _bookingService = bookingService;

    [HttpGet("InitialBooking")]
    public IActionResult BookingDetalis([FromQuery] int farmId, [FromQuery] DateTime checkInDate, [FromQuery] int nights)

    {
        Result result = _bookingService.BookingDetalis(farmId, checkInDate, nights);
        return Ok(result);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateBook([FromBody] BookingModel request)
    {
        return Ok( _bookingService.CreateBooking(request));
    }
 
    [HttpGet("GetAll")]
    public IActionResult GetAll([FromQuery] string userId)
    {
        Result result = _bookingService.GetAllBookings(userId);
        return Ok(result);
    }

    [HttpGet("GetById/{BookingId:int}")]
    public IActionResult Get(int BookingId)
    {
        return Ok(_bookingService.GetBookingById(BookingId));
    }

  
}
