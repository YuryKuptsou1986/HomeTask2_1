using AutoMapper;
using Model.Insert;
using Model.Update;
using Model.View;
using Domain.Entities;

namespace BLL.Mappings
{
    internal class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>()
                .ForMember(x => x.ParentCategoryId, opt => opt.Ignore());
            CreateMap<Category, CategoryViewModel>();

            
            CreateMap<ItemViewModel, Item>()
                .ForMember(x => x.CategoryId, opt => opt.Ignore());
            CreateMap<Item, ItemViewModel>();

            CreateMap<ItemInsertModel, Item>()
                .ForMember(x=>x.Id, opt => opt.Ignore())
                .ForMember(x=>x.Category, opt => opt.AllowNull());
            
            CreateMap<ItemUpdateModel, Item>();

            CreateMap<CategoryInsertModel, Category>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.ParentCategory, opt => opt.AllowNull());

            CreateMap<CategoryUpdateModel, Category>();
        }
    }
}
