using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Infrastructure.Repository.UnitOfWork;

namespace FarmBookingBackend.Application.Services.Implemintation;

public class FarmRoomService(IUnitOfWork unitOfWork) : IFarmRoomService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public Result Create(FarmRoom farmRoom)
    {
        Result result = new();
        _unitOfWork.FarmRoom.Add(farmRoom);
        _unitOfWork.SaveChanges();
        result.Code = 200;
        result.Response = farmRoom;
        return result ;
    }

    public Result GetAll(int FarmId)
    {
        Result result = new()
        {
            Response = _unitOfWork.FarmRoom.GetAll(x => x.FarmId == FarmId)
        };
        return result;
    }

    public Result GetById(int id)
    {
        var result = _unitOfWork.FarmRoom.Get(x => x.FarmRoom_Number == id);
        if (result is null)
        {
            return new Result { Code = 400 };
        }
        return new Result { Code = 200, Response = result };
    }

    public Result Update(FarmRoom farmRoom)
    {
        _unitOfWork.FarmRoom.update(farmRoom);
        _unitOfWork.SaveChanges();
        return new Result { Code = 200, Response = farmRoom };
    }
}
