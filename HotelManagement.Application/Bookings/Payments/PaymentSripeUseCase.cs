using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Application.Bookings.Payments;

public class PaymentSripeUseCase(
    IPaymentStripeAdapter paymentStripeAdapter

    ) : IPaymentSripeUseCase
{
    public async Task<PaymentResult> Handle(Guid bookingId, Payment payment)
    {
        StripePaymentManager stripeManager = new StripePaymentManager(paymentStripeAdapter);
        var purchaseManager = new PurchaseManager(stripeManager);
        return await purchaseManager.Pay(payment);
    }
}
