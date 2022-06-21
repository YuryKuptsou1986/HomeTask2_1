using Model.Insert;
using Model.Update;
using Model.View;

namespace BLL.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> ListAsync();
        Task<CategoryViewModel> GetAsync(int id);
        Task AddAsync(CategoryInsertModel category);
        Task DeleteAsync(int id);
        Task UpdateAsync(CategoryUpdateModel category);
    }
}
