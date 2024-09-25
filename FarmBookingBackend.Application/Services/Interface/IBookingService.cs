using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Application.Services.Interface;

public interface IBookingService
{
    Result BookingDetalis(int farmId, DateTime checkInDate, int nights);
    Result CreateBooking(BookingModel booking);
    Result GetBookingById(int bookingId);
    Result GetAllBookings(string? userId);

    //Result UpdateStatus(int bookingId);
   
}
