using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Application.Bookings.Payments;

public interface IPaymentPaypalUseCase
{
    Task<PaymentResult> Handle(Guid bookingId, Payment payment);
}
