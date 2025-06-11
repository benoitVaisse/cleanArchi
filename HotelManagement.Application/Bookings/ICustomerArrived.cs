namespace HotelManagement.Application.Bookings;

public interface ICustomerArrived
{
    Task Handle(Guid bookingId);
}
