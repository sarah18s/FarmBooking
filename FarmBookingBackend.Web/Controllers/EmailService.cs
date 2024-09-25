
using Microsoft.AspNetCore.Mvc;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;

namespace FarmBookingBackend.Web.Controllers;

[Controller]
[Route("api/[Controller]")]
public class EmailController : ControllerBase
{

    private readonly IEmailService _mailingService;

    public EmailController(IEmailService mailingService)
    {
        _mailingService = mailingService;
    }
    [HttpPost("send")]
    public async Task<IActionResult> SendMail([FromForm] MailRequestModel dto)
    {
        await _mailingService.SendEmailAsync(dto.ToEmail, dto.Subject, dto.Message);
        return Ok();
    }

}



