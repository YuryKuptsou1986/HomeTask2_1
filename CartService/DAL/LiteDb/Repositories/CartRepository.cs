using CartService.Domain.Entities;
using CartService.DAL.LiteDb.DbContext;
using CartService.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace CartService.DAL.LiteDb.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ILiteDBContext _dbContext;

        public CartRepository(ILiteDBContext dbContext)
        {
            if (dbContext == null) {
                throw new ArgumentNullException("Can not be null", nameof(dbContext));
            }
            _dbContext = dbContext;
        }

        public int Add(Cart cart)
        {
            return _dbContext.Database.GetCollection<Cart>().Insert(cart);
        }

        public bool Delete(int id)
        {
            return _dbContext.Database.GetCollection<Cart>().Delete(id);
        }

        public IEnumerable<Cart> GetList()
        {
            return _dbContext.Database.GetCollection<Cart>().FindAll();
        }
    }
}
