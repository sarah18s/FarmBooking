using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Infrastructure.Repository.UnitOfWork;

namespace FarmBookingBackend.Application.Services.Implemintation;

public class AmenityService(IUnitOfWork unitOfWork) : IAmenityService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public Result Create(Amenity amenity)
    {
        Result result = new();
  
        _unitOfWork.Amenity.Add(amenity);
        _unitOfWork.SaveChanges();
        result.Code = 200;
        result.Response = amenity;
        return result;
    }

    public Result Delete(int id)
    {
        Amenity amenity = _unitOfWork.Amenity.Get(x => x.Id == id, tracked: true)!;
        amenity.IsDelete = true;
        amenity.IsAvailable = false;
        _unitOfWork.SaveChanges();
        return new Result { Code = 200, Response = amenity };
    }

    public Result GetAll(int farmId)
    {
        Result result = new()
        {
            Response = _unitOfWork.Amenity.GetAll( x => x.IsAvailable == true && x.FarmId == farmId)
        };
        return result;
    }

    public Result GetById(int id)
    {
        var amenity = _unitOfWork.Amenity.Get(x => x.Id == id);
        if (amenity is null)
        {
            return new Result { Code = 400 };
        }
        return new Result { Code = 200, Response = amenity };
    }

    public Result Update(AmenityDto amenityDto)
    {
        Amenity amenity = _unitOfWork.Amenity.Get(x => x.Id == amenityDto.Id)!;
        amenity.Updated_Date = DateTime.Now;
        amenity.Name = amenityDto.Name ?? amenity.Name;
        amenity.Description = amenityDto.Description ?? amenity.Description;
        _unitOfWork.Amenity.update(amenity);
        _unitOfWork.SaveChanges();
        return new Result { Code = 200, Response = amenityDto };


    }
}
