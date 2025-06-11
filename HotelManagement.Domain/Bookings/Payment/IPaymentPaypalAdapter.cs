namespace HotelManagement.Domain.Bookings.Payment;

public interface IPaymentPaypalAdapter
{
    Task<PaymentResult> ProcessPaymentAsync(Payment payment);
}

