using Models.Models;

namespace Models.Abstractions
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task DeleteAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task UpdateAsync(User user);
    }

}
