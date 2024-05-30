using AutoMapper;
using OCS.DTO;
using OCS.ViewModel.Order;
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
    public class OrderItemProfile:Profile
    {
        public OrderItemProfile()
        {
            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.OrderDto, opt => opt.MapFrom(src => src.OrderViewModel));
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.OrderViewModel, opt => opt.MapFrom(src => src.OrderDto));

            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.ProductViewModel));
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.ProductViewModel, opt => opt.MapFrom(src => src.ProductDto));



            CreateMap<OrderViewModel, OrderDto>().ForMember(dest => dest.PaymentsDto, opt => opt.Ignore());
            CreateMap<OrderDto, OrderViewModel>().ForMember(dest => dest.PaymentsViewModel, opt => opt.Ignore());

            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.ReviewsDto, opt => opt.MapFrom(src => src.ReviewsViewModel));
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.ReviewsViewModel, opt => opt.MapFrom(src => src.ReviewsDto));

            CreateMap<ReviewViewModel, ReviewDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.ProductViewModel));
            CreateMap<ReviewDto, ReviewViewModel>().ForMember(dest => dest.ProductViewModel, opt => opt.MapFrom(src => src.ProductDto));
        }
    }
}
