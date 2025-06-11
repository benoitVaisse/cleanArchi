namespace HotelManagement.Domain;

public interface IBaseRepository<T> where T : IEntity
{
    Task<T?> GetAsync(Guid id);
}
