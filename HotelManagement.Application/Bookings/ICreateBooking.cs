using HotelManagement.Application.Bookings.Dtos;

namespace HotelManagement.Application.Bookings;

public interface ICreateBooking
{
    Task<BookingDto> Handle(BookingDto dto);
}
