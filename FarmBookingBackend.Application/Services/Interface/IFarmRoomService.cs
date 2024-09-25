using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Application.Services.Interface;

public interface IFarmRoomService
{
    Result GetAll(int FarmId);
    Result GetById(int id);
    Result Create(FarmRoom farmRoom);
    Result Update(FarmRoom farmRoom);
    
}
