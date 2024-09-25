using AutoMapper;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;
using FarmBookingBackend.Domain.Enum;
using FarmBookingBackend.Infrastructure.Repository.UnitOfWork;

namespace FarmBooking.Application.Services.Implementation;

public class FarmService(IUnitOfWork unitOfWork, IMapper mapper) : IFarmService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;

    public async Task<Result> Create(FarmModel farm)
    {
        Result result = new();
        if (farm.Image is not null && farm.Image.Length > 0)
        {
            List<string> ValidExtention =
            [
                ".jpg",".png",".gif",".jpeg"
            ];
            string FileExtention = Path.GetExtension(farm.Image.FileName);
            if (!ValidExtention.Contains(FileExtention) || farm.Image.Length > 5 * 1024 * 1024)
            {
                result.Code = 400;
                result.Error = "the file format is invalid or File size exceeds limit";
            }
            else
            {
                var fileName = Guid.NewGuid().ToString() + FileExtention; 
                string path = Path.Combine(Directory.GetCurrentDirectory(), @"images");
                FileStream stream = new(Path.Combine(path, fileName), FileMode.Create);
                await farm.Image.CopyToAsync(stream);
                var MappedFarm = _mapper.Map<Farm>(farm);
                if (MappedFarm is null)
                {
                    result.Code = 400;
                    result.Error = "Can not Mapped";
                }
                else
                {
                    MappedFarm!.ImageUrl = @"\images\" + fileName;
                    result.Code = 200;
                    result.Response = farm;
                    _unitOfWork.Farm.Add(MappedFarm);
                    await _unitOfWork.SaveChangesAsync();
                }
            }
        }
        else
        { 
            var MappedFarm = _mapper.Map<Farm>(farm);
            if (MappedFarm is null)
            {
                result.Code = 400;
                result.Error = "Can not Mapped";
            }
            else
            {
                MappedFarm!.ImageUrl = "https://placehold.co/600x400";
                MappedFarm.Created_Date = DateTime.Now;
                result.Code = 200;
                result.Response = farm;
                _unitOfWork.Farm.Add(MappedFarm);
                await _unitOfWork.SaveChangesAsync();
            }
        }
        return result;
    }

    public Result Delete(int id)
    {
        Farm farm = _unitOfWork.Farm.Get(x => x.Id == id , tracked : true)!;
        farm.IsDelete = true;
        farm.IsAvailable = false;
        _unitOfWork.SaveChanges();
        return new Result { Code = 200  , Response = farm};
    }

    public Result GetAll()
    {
        var result = _unitOfWork.Farm.GetAll(x => x.IsAvailable && !x.IsDelete);
        if (result is null)
        {
            return new Result { Code = 204 };
        }
        return new Result { Code = 200, Response = result };
    }

    public async Task<Result> Update(FarmModel farmModel, int id)
    {
        Result result = new();
        var farm = _unitOfWork.Farm.Get(x => x.Id == id, tracked: true)!;
        if (farm is null)
        {
            result.Code = 400;
        }
        else
        {
            if (farm.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(farm.Image.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), @"images");

                if (!string.IsNullOrEmpty(farm.ImageUrl))
                {
                    var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), farm.ImageUrl.TrimStart('\\'));
                    if (File.Exists(oldImagePath))
                    {

                        File.Delete(oldImagePath);
                    }
                }
                var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create);
                farm.Image.CopyTo(fileStream);
                farm.ImageUrl = @"\images" + fileName;
            }
            farm.Updated_Date = DateTime.Now;
            farm.Name = farmModel.Name ?? farm.Name;
            farm.Description = farmModel.Description ?? farm.Description;
            farm.Price = farmModel.Price == 0 ? farm.Price : farmModel.Price;
            farm.Sqft = farmModel.Sqft == 0 ? farm.Sqft : farmModel.Sqft;
            farm.Occupancy = farmModel.Occupancy == 0 ? farm.Occupancy : farmModel.Occupancy;
            _unitOfWork.Farm.update(farm);
            await _unitOfWork.SaveChangesAsync();
            result.Code = 200;
            result.Response = farmModel;
        }
        return result;
    }
    public Result GetById(int id)
    {
        var result = _unitOfWork.Farm.Get(x => x.Id == id && x.IsAvailable && !x.IsDelete,
        includeProperties: "Amenities,FarmRooms");
        if (result is null)
        {
            return new Result { Code = 400 };
        }
        
        return new Result { Code = 200, Response = result };
    }

    public Result GetFarmsAvailabilityByDate(DateTime checkInDate)
    {
      
        if( checkInDate <= DateTime.Now )
        {
            return new Result { Code = 400 };
        }
        var farmList = _unitOfWork.Farm.GetAll(x => x.IsAvailable && !x.IsDelete,
            includeProperties: "Amenities,FarmRooms")!.ToList();

        List<Farm> avilableFarms = [];
        foreach ( var farm in farmList) {
            var Booking = IsFarmAvailableByDate(farm.Id,checkInDate );
            if(Booking.Code! == 200)
            {
                avilableFarms.Add(farm);

            }
        }
        if (avilableFarms is null)
        {
            return new Result { Code = 204 };
        }
        return new Result { Code = 200, Response = avilableFarms };
    }

    public Result IsFarmAvailableByDate(int farmId, DateTime checkInDate)
    {
       
        var BookedFarms = _unitOfWork.Booking.GetAll(u => u.Status == Status.CONFIRMED.ToString() 
        && u.FarmId == farmId &&
        (checkInDate <= u.CheckOutDate))?.Count();

        if(BookedFarms == 0)
        {
            return new Result { Code = 200 };
        }
        return new Result { Code = 204 };
    } 
}
