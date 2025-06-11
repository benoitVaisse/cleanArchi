
using HotelManagement.Application.Authentication;
using HotelManagement.Domain.Bookings;

namespace HotelManagement.Application.Rooms;

public class PatchCleanedRoom(
        IRoomRepository roomRepository,
        ICurrentUserTokenAdapter currentUserTokenAdapter
    ) : IPatchCleanedRoom
{
    public async Task Handle(Guid roomId)
    {
        Room room = await roomRepository.GetAsync(roomId) ?? throw new NullReferenceException("rooms doest exist");
        if (room.IsCleaned)
            throw new Exception("room already clean");

        room.CleanedBy = currentUserTokenAdapter.GetUserId()!.Value;
        room.IsCleaned = true;
        room.LastCleanedDate = DateTime.UtcNow;
        _ = roomRepository.UpdateRoom(room);
        return;
    }
}
