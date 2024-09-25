using AutoMapper;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Domain.Helper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RegisterModel, ApplicationUser>();
        CreateMap<FarmModel, Farm>();
        CreateMap<Farm, FarmModel>();
        CreateMap<BookingModel , Booking>();
       
    }
}
