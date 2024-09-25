using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmBookingBackend.Domain.Entities
{
    public class CreatePaymentIntentRequest
    {
        public double TotalCost { get; set; }
        public int BookingId { get; set; }
    }
}
