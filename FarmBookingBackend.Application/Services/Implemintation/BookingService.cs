using AutoMapper;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Domain.Enum;
using FarmBookingBackend.Infrastructure.Repository.UnitOfWork;

namespace FarmBookingBackend.Application.Services.Implemintation;

public class BookingService
    (IUnitOfWork unitOfWork, IMapper mapper , IFarmService farmService , IEmailService emailService) 
    : IBookingService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly IFarmService _farmService = farmService;
    private readonly IEmailService _emailService = emailService;

    public Result BookingDetalis(int farmId, DateTime checkInDate, int nights)
    {
        Farm farm = (Farm)_farmService.GetById(farmId).Response!;
        FarmModel farmModel = _mapper.Map<FarmModel>(farm);
        BookingDetalisModel bookingDetalis = new()
        {
            farm = farmModel,
            FarmId = farmId,
            CheckInDate = checkInDate,
            nights = nights,
            TotalCost = farmModel.Price * nights

        };

        return new Result { Code = 200 ,Response = bookingDetalis };
    }

    public Result CreateBooking(BookingModel request)
    { 
        var booking = _mapper.Map<Booking>(request);
        booking.Status = Status.CONFIRMED.ToString();
        var book = _unitOfWork.Booking.Add(booking);
        _unitOfWork.SaveChanges();

        if(book is not null){
            _emailService.SendEmailAsync(booking.Email, "Successfull Booking", " have a nice trip");
            return new Result { Code = 200 };

        }
        return new Result { Code = 400 };

    }

   public Result GetAllBookings(string? userId)
{
    Result result = new();
    IEnumerable<Booking> book;

    // Check if userId is provided
    if (!string.IsNullOrEmpty(userId))
    {
        // Remove spaces in includeProperties
        book = _unitOfWork.Booking.GetAll(u => u.UserId == userId, includeProperties: "ApplicationUser,Farm");

        // Check if any bookings were found
        if (book.Any())
        {
            result.Code = 200;
            result.Response = book;
        }
        else
        {
            result.Code = 204; // No Content
        }
    }
    else
    {
        // Get all bookings if no userId is provided
        book = _unitOfWork.Booking.GetAll(includeProperties: "ApplicationUser,Farm");

        // Check if any bookings were found
        if (book.Any())
        {
            result.Code = 200;
            result.Response = book;
        }
        else
        {
            result.Code = 204; // No Content
        }
    }

    return result;
}

    public Result GetBookingById(int bookingId)
    {
        var book = _unitOfWork.Booking.Get(x => x.Id == bookingId);
        if (book is not null)
            return new Result { Code = 200, Response = book };
        else
            return new Result { Code = 204 };
    }

   

  
}
