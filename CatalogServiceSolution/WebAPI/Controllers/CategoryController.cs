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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("get")]
        public async Task<CategoryViewModel> Get(int id)
        {
            return await _categoryService.GetAsync(id);
        }

        [HttpGet("list")]
        public async Task<IEnumerable<CategoryViewModel>> List()
        {
            var list = await _categoryService.ListAsync();
            return list;
        }

        [HttpPatch("update")]
        public async Task Update(CategoryUpdateModel category)
        {
            await _categoryService.UpdateAsync(category);
        }

        [HttpPost("add")]
        public async Task Add(CategoryInsertModel category)
        {
            await _categoryService.AddAsync(category);
        }

        [HttpDelete("delete")]
        public async Task Delete(int id)
        {
            await _categoryService.DeleteAsync(id);
        }

    }
}
