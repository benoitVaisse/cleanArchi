namespace HotelManagement.Domain.Bookings.Payment;

public interface IPaymentStripeAdapter
{
    Task<PaymentResult> ProcessPaymentAsync(Payment payment);
}
