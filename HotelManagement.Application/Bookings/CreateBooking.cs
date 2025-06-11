using HotelManagement.Application.Bookings.Dtos;
using HotelManagement.Domain.Bookings;

namespace HotelManagement.Application.Bookings;

public class CreateBooking(
        IRoomRepository roomRepository,
        IBookingRepository bookingRepository
    ) : ICreateBooking
{
    public async Task<BookingDto> Handle(BookingDto dto)
    {
        Room? room = await roomRepository.GetAsync(dto.RoomId) ?? throw new NullReferenceException("room doesn't exist");
        Booking booking = await bookingRepository.Create(new Booking()
        {
            RoomId = dto.RoomId,
            From = dto.From,
            To = dto.To,
            CustomerId = dto.CustomerId,
            Price = (room.Price * (dto.To.Date - dto.From.Date).Days),
            Payed = false
        });

        dto.Id = booking.Id;
        dto.CreatedOn = booking.CreatedOn;
        return dto;
    }
}
