namespace HotelManagement.Domain.Bookings;

public interface IBookingRepository : IBaseRepository<Booking>
{
    Task<List<Guid>> GetUnAvailableRoomsIdsForDate(DateTime from, DateTime to);
    Task<Booking> Create(Booking booking);
    Task<Booking> Update(Booking booking);
}
