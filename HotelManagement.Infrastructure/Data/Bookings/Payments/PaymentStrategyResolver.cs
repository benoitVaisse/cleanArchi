using HotelManagement.Domain.Bookings.Payment;

namespace HotelManagement.Infrastructure.Data.Bookings.Payments;

public class PaymentStrategyResolver : IPaymentStrategyResolver
{
    private readonly Dictionary<string, IPaymentManager> _strategies;

    public PaymentStrategyResolver(IEnumerable<IPaymentManager> strategies)
    {
        _strategies = strategies.ToDictionary(s => s.Method, StringComparer.OrdinalIgnoreCase);
    }

    public IPaymentManager Resolve(string method)
    {
        if (_strategies.TryGetValue(method, out var strategy))
            return strategy;

        throw new NotSupportedException($"Payment method '{method}' is not supported.");
    }
}
