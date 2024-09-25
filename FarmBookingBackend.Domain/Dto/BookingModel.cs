using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Domain.Dto
{
    public class BookingModel
    {
        public string UserId { get; set; }
        public int FarmId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public double TotalCost { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Nights { get; set; }

    }
}
