using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Infrastructure.Data.Bookings.Payments;

public class PaymentStripeAdapter : IPaymentStripeAdapter
{
    public Task<PaymentResult> ProcessPaymentAsync(Payment payment)
    {
        Console.WriteLine("Processing payment with Stripe calling Stripe API");
        return Task.FromResult(PaymentResult.SuccessResult());
    }
}
