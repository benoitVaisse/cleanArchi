using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Application.Bookings.Payments;

public class PurchaseManager(IPaymentStrategyResolver paymentStrategyResolver) : IPurchaseManager
{
    public async Task<PaymentResult> Pay(Payment payment, string method)
    {
        var strategy = paymentStrategyResolver.Resolve(method);
        return await strategy.Pay(payment);
    }
}

public interface IPurchaseManager
{
    Task<PaymentResult> Pay(Payment payment, string method);
}
