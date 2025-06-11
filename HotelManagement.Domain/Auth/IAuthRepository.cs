using HotelManagement.Domain.Users;

namespace HotelManagement.Domain.Auth;

public interface IAuthRepository
{
    Task<User?> AuthUser(string email, string password);
}
