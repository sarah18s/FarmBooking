using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmBookingBackend.Domain.Dto
{
    public class BookingDetalisModel
    {
        public FarmModel farm { get; set; }
        public int FarmId { get; set; }
        public int nights { get; set; }
        public double TotalCost { get; set; }
        public DateTime CheckInDate { get; set;}
        public DateTime CheckOutDate { get; set; }

    }
}
