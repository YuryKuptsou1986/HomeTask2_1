using Model.Insert;
using Model.Update;
using Model.View;

namespace BLL.Services
{
    public interface IItemService
    {
        Task<IEnumerable<ItemViewModel>> ListAsync();
        Task<ItemViewModel> GetAsync(int id);
        Task AddAsync(ItemInsertModel item);
        Task DeleteAsync(int id);
        Task UpdateAsync(ItemUpdateModel item);
    }
}
