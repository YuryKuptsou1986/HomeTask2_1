using CartService.Domain.Entities;
using System.Collections.Generic;

namespace CartService.DAL.Interfaces
{
    public interface ICartRepository
    {
        public IEnumerable<Cart> GetList();
        public int Add(Cart cart);
        public bool Delete(int id);
    }
}
