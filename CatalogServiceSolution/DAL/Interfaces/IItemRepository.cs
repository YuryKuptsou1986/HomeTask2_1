using Domain.Entities;

namespace DAL.Interfaces
{
    public interface IItemRepository
    {
        Task<List<Item>> ListAsync();
        Task<Item> GetAsync(int id);
        Task AddAsync(Item item);
        Task DeleteAsync(int id);
        Task UpdateAsync(Item item);
    }
}
