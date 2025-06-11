using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Infrastructure.Data.Bookings.Payments;

public class StripePaymentManager(IPaymentStripeAdapter paymentStripeAdapter) : IPaymentManager
{
    public string Method => "stripe";

    public async Task<PaymentResult> Pay(Payment payment)
    {
        return await paymentStripeAdapter.ProcessPaymentAsync(payment);
    }
}