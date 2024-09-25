using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Application.Services.Interface;

public interface IFarmService
{
    Result GetAll();
    Result GetById(int id);
    Task<Result> Create(FarmModel farm);
    Task<Result> Update(FarmModel farm , int id);
    Result Delete(int id);
    Result GetFarmsAvailabilityByDate(DateTime checkInDate);
   
}