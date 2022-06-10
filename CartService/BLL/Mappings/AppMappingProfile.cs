using AutoMapper;
using CartService.BLL.Entities;
using CartService.Domain.Entities;

namespace CartService.BLL.Mappings
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<ImageInfo, ImageInfoViewModel>().ReverseMap();
            CreateMap<Cart, CartViewModel>().ReverseMap();
        }
    }
}