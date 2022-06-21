using CartService.Domain.Entities;
using System.Collections.Generic;

namespace CartService.BLL.Services
{
    public interface ICartService
    {
        public IEnumerable<Cart> GetList();
        public int Add(Cart cart);
        public bool Delete(int id);
    }
}
