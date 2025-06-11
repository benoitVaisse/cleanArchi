namespace HotelManagement.Domain.Bookings;

public interface IRoomRepository : IBaseRepository<Room>
{
    Task<List<Room>> GetRoomsByUnAvailableIds(List<Guid> roomsIds);
    Task<List<Room>> GetRoomsToClean();
    Task<Room> UpdateRoom(Room room);
}
