using CartService.Domain.Entities;
using CartService.DAL.Interfaces;
using System.Collections.Generic;
using System;

namespace CartService.BLL.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;

        public CartService(ICartRepository cartRepository)
        {
            if(cartRepository == null) {
                throw new ArgumentNullException("Can not be null", nameof(cartRepository));
            }

            _repository = cartRepository;
        }

        public int Add(Cart cart)
        {
            return _repository.Add(cart);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Cart> GetList()
        {
            return _repository.GetList();
        }
    }
}
