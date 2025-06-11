using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Application.Bookings.Payments;

public class PaymentSripeUseCase(
    IPurchaseManager purchaseManager
    ) : IPaymentSripeUseCase
{
    public async Task<PaymentResult> Handle(Guid bookingId, Payment payment)
    {
        return await purchaseManager.Pay(payment, "stripe");
    }
}
