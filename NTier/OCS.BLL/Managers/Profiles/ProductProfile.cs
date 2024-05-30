using AutoMapper;
using OCS.DTO;
using OCS.ViewModel.Category;
using OCS.ViewModel.OrderItem;
using OCS.ViewModel.Product;
using OCS.ViewModel.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.CategoryDto, opt => opt.MapFrom(src => src.CategoryViewModel));
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.CategoryViewModel, opt => opt.MapFrom(src => src.CategoryDto));

            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItemsViewModel));
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.OrderItemsViewModel, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.ReviewsDto, opt => opt.MapFrom(src => src.ReviewsViewModel));
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.ReviewsViewModel, opt => opt.MapFrom(src => src.ReviewsDto));






            CreateMap<CategoryViewModel, CategoryDto>().ForMember(dest => dest.ProductsDto, opt => opt.Ignore());
            CreateMap<CategoryDto, CategoryViewModel>().ForMember(dest => dest.ProductsViewModel, opt => opt.Ignore());

            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.ProductDto, opt => opt.Ignore());
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.ProductViewModel, opt => opt.Ignore());


            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.OrderDto, opt => opt.MapFrom(src => src.OrderViewModel));
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.OrderViewModel, opt => opt.MapFrom(src => src.OrderDto));


            CreateMap<ReviewViewModel, ReviewDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.ProductViewModel));
            CreateMap<ReviewDto, ReviewViewModel>().ForMember(dest => dest.ProductViewModel, opt => opt.MapFrom(src => src.ProductDto));
        }
    }
}
