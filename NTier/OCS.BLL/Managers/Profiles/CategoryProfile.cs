using AutoMapper;
using OCS.DTO;
using OCS.ViewModel.Category;
using OCS.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryViewModel, CategoryDto>().ForMember(dest => dest.ProductsDto, opt => opt.MapFrom(src => src.ProductsViewModel));
            CreateMap<CategoryDto, CategoryViewModel>().ForMember(dest => dest.ProductsViewModel, opt => opt.MapFrom(src => src.ProductsDto));





            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.CategoryDto, opt => opt.Ignore());
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.CategoryViewModel, opt => opt.Ignore());

            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.Ignore());
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.OrderItemsViewModel, opt => opt.Ignore());

            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.ReviewsViewModel, opt => opt.MapFrom(src => src.ReviewsDto));
            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.ReviewsDto, opt => opt.MapFrom(src => src.ReviewsViewModel));



            CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
        }
    }
}
