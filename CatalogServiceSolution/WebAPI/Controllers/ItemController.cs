using AutoMapper;
using Model.Insert;
using Model.Update;
using Model.View;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public ItemController(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        [HttpGet("get")]
        public async Task<ItemViewModel> Get(int id)
        {
            return await _itemService.GetAsync(id);
        }

        [HttpGet("list")]
        public async Task<IEnumerable<ItemViewModel>> List()
        {
            return await _itemService.ListAsync();
        }

        [HttpPatch("update")]
        public async Task Update(ItemUpdateModel item)
        {
            await _itemService.UpdateAsync(item);
        }

        [HttpPost("add")]
        public async Task Add(ItemInsertModel item)
        {
            await _itemService.AddAsync(item);
        }

        [HttpDelete("delete")]
        public async Task Delete(int id)
        {
            await _itemService.DeleteAsync(id);
        }
    }
}
