using DAL.Context;
using DAL.Exceptions;
using DAL.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class ItemRepository : IItemRepository
    {
        private readonly IApplicationDbContext _dbContext;

        public ItemRepository(IApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Items.FindAsync(new object[] { id });

            if (entity == null) {
                throw new NotFoundException(nameof(Item), id);
            }

            _dbContext.Items.Remove(entity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Item> GetAsync(int id)
        {
            var entity = await _dbContext.Items.FindAsync(new object[] { id });

            if (entity == null) {
                throw new NotFoundException(nameof(Item), id);
            }

            return entity;
        }

        public async Task AddAsync(Item item)
        {
            await _dbContext.Items.AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Item>> ListAsync()
        {
            var items  = await _dbContext.Items.Include(x=>x.Category).ToListAsync();
            return items;
        }

        public async Task UpdateAsync(Item item)
        {
            var entity = await _dbContext.Items.FindAsync(new object[] { item.Id });

            if (entity == null) {
                throw new NotFoundException(nameof(Item), item.Id);
            }

            entity.Update(item.Name, item.Description, item.Image, item.CategoryId, item.Price, item.Amount);

            await _dbContext.SaveChangesAsync();
        }
    }
}
