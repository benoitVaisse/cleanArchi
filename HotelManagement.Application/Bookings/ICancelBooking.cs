namespace HotelManagement.Application.Bookings;

public interface ICancelBooking
{
    Task<string> Handle(Guid bookingId, bool refund);
}
