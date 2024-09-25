using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Application.Services.Interface;

public interface IAmenityService
{
    Result GetAll(int farmId);
    Result Create(Amenity amenity);
    Result Update(AmenityDto amenityDto);
    Result GetById(int id);
    Result Delete(int id);
}
