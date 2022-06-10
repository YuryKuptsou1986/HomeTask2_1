using AutoMapper;
using CartService.BLL.Entities;
using CartService.Domain.Entities;

namespace CartService.BLL.Mappings
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<ImageInfo, ImageInfoDto>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();
        }
    }
}