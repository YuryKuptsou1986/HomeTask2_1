using AutoMapper;
using Model.Insert;
using Model.Update;
using Model.View;
using DAL.Interfaces;
using Domain.Entities;

namespace BLL.Services
{
    internal class ItemService : IItemService
    {
        private readonly IItemRepository _repository;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<ItemViewModel> GetAsync(int id)
        {
            var item = await _repository.GetAsync(id);
            return _mapper.Map<ItemViewModel>(item);
        }

        public async Task AddAsync(ItemInsertModel item)
        {
            var newItem = _mapper.Map<Item>(item);
            await _repository.AddAsync(newItem);
        }

        public async Task<IEnumerable<ItemViewModel>> ListAsync()
        {
            var items = await _repository.ListAsync();
            return _mapper.Map<IEnumerable<ItemViewModel>>(items);
        }

        public async Task UpdateAsync(ItemUpdateModel item)
        {
            var updatedItem = _mapper.Map<Item>(item);
            await _repository.UpdateAsync(updatedItem);
        }
    }
}
