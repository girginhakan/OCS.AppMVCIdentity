using AutoMapper;
using OCS.DTO;
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
    public class ReviewPofile:Profile
    {
        public ReviewPofile()
        {
            CreateMap<ReviewViewModel, ReviewDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.ProductViewModel));
            CreateMap<ReviewDto, ReviewViewModel>().ForMember(dest => dest.ProductViewModel, opt => opt.MapFrom(src => src.ProductDto));



            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItemsViewModel));
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.OrderItemsViewModel, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.OrderDto, opt => opt.Ignore());
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.OrderViewModel, opt => opt.Ignore());
        }
    }
}
