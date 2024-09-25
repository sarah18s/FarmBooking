using Microsoft.Extensions.Configuration;
using Stripe;
using Stripe.Checkout;
using FarmBookingBackend.Application.Services.Interface;
using FarmBookingBackend.Domain.Dto;
using FarmBookingBackend.Domain.Entities;

namespace FarmBookingBackend.Application.Services.Implemintation
{
    public class PaymentService : IPaymentService
    {
       
        public async Task<Result> CreatePaymentIntent(double totalCost)
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = (long)(totalCost * 100), // Amount in cents
                Currency = "usd",
                PaymentMethodTypes = ["card" ],
            };
            var service = new PaymentIntentService();
            var intent = await service.CreateAsync(options);

            return new Result{ Response = intent.ClientSecret };
        }
    }
}

