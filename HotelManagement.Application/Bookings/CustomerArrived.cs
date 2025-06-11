using HotelManagement.Domain.Bookings;
using HotelManagement.Domain.Exceptions;

namespace HotelManagement.Application.Bookings;

public class CustomerArrived(
        IBookingRepository bookingRepository
    ) : ICustomerArrived
{
    public async Task Handle(Guid bookingId)
    {
        Booking booking = await bookingRepository.GetAsync(bookingId)
            ?? throw new NotFoundException("booking doest't exist");

        booking.HasCome = true;
        _ = await bookingRepository.Update(booking);
    }
}
