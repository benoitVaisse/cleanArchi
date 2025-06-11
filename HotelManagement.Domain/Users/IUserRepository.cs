namespace HotelManagement.Domain.Users;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> Create(User user);
}
