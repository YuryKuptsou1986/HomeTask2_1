using AutoMapper;
using DAL.Interfaces;
using Domain.Entities;
using Model.Insert;
using Model.Update;
using Model.View;

namespace BLL.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<CategoryViewModel> GetAsync(int id)
        {
            var category = await _repository.GetAsync(id);
            return _mapper.Map<CategoryViewModel>(category);
        }

        public async Task AddAsync(CategoryInsertModel category)
        {
            var newCategory = _mapper.Map<Category>(category);
            await _repository.AddAsync(newCategory);
        }

        public async Task<IEnumerable<CategoryViewModel>> ListAsync()
        {
            var categories = await _repository.ListAsync();
            return _mapper.Map<IEnumerable<CategoryViewModel>>(categories);
        }

        public async Task UpdateAsync(CategoryUpdateModel category)
        {
            var updatedCategory = _mapper.Map<Category>(category);
            await _repository.UpdateAsync(updatedCategory);
        }
    }
}
