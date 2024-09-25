namespace FarmBookingBackend.Domain.Entities;

public class Result
{
    public int Code { get; set; }
    public object? Response { get; set; }
    public string? Error { get; set; }
}
