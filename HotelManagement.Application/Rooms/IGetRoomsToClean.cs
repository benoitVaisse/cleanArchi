using HotelManagement.Application.Rooms.Dtos;

namespace HotelManagement.Application.Rooms;

public interface IGetRoomsToClean
{
    Task<List<RoomDto>> Handle();
}
