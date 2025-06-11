using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Application.Bookings.Payments;

public interface IPaymentManager
{
    Task<PaymentResult> Pay(Payment payment);
}

public class PaypalPaymentManager(IPaymentPaypalAdapter paymentPaypalAdapter) : IPaymentManager
{
    public async Task<PaymentResult> Pay(Payment payment)
    {
        return await paymentPaypalAdapter.ProcessPaymentAsync(payment);
    }
}

public class StripePaymentManager(IPaymentStripeAdapter paymentStripeAdapter) : IPaymentManager
{
    public async Task<PaymentResult> Pay(Payment payment)
    {
        return await paymentStripeAdapter.ProcessPaymentAsync(payment);
    }
}

public class PurchaseManager(IPaymentManager paymentManager)
{
    public async Task<PaymentResult> Pay(Payment payment)
    {
        return await paymentManager.Pay(payment);
    }
}
