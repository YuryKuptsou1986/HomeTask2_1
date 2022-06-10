using AutoMapper;
using CartService.BLL.Entities;
using CartService.BLL.Services;
using CartService.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CartService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartServiceController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;

        public CartServiceController(ICartService cartService, IMapper mapper)
        {
            _cartService = cartService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<CartDto> GetAll()
        {
            return _cartService.GetList().Select(x => _mapper.Map<CartDto>(x));
        }

        [HttpPost]
        public int Add(CartDto cartDto)
        {
            return _cartService.Add(_mapper.Map<Cart>(cartDto));
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _cartService.Delete(id);
        }
    }
}
