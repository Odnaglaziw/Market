using Models.Models;

namespace Models.Abstractions
{
    public interface IReviewRepository
    {
        Task AddAsync(Review review);
        Task DeleteAsync(int id);
        Task<IEnumerable<Review>> GetAllAsync();
        Task<List<Review>> GetByProductIdAsync(int id);
        Task UpdateAsync(Review review);
    }

}
