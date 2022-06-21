using Domain.Entities;

namespace DAL.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> ListAsync();
        Task<Category> GetAsync(int id);
        Task AddAsync(Category item);
        Task DeleteAsync(int id);
        Task UpdateAsync(Category item);
    }
}
