using HotelManagement.Domain.Users;

namespace HotelManagement.Infrastructure.Data.Users
{
    public class UserRepository : Context<User>, IUserRepository
    {
        private readonly string path = "./../HotelManagement.Domain/Users/users.json";
        public async Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid();
            user.HashedPassword = PasswordHash.Instance.HashPassword(user, user.HashedPassword);
            await AddData(path, user);
            return user;
        }

        public Task<User> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
