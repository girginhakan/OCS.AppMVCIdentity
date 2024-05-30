using AutoMapper;
using OCS.DTO;
using OCS.ViewModel.Order;
using OCS.ViewModel.OrderItem;
using OCS.ViewModel.Payment;
using OCS.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Profiles
{
    public class PaymentProfile:Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentViewModel, PaymentDto>().ForMember(dest => dest.OrderDto, opt => opt.MapFrom(src => src.OrderViewModel));
            CreateMap<PaymentDto, PaymentViewModel>().ForMember(dest => dest.OrderViewModel, opt => opt.MapFrom(src => src.OrderDto));


            //---------------------------------


            CreateMap<OrderViewModel, OrderDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItemsViewModel));
            CreateMap<OrderDto, OrderViewModel>().ForMember(dest => dest.OrderItemsViewModel, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.ProductViewModel));
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.ProductViewModel, opt => opt.MapFrom(src => src.ProductDto));




            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.CategoryDto, opt => opt.Ignore());
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.CategoryViewModel, opt => opt.Ignore());

            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.Ignore());
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.OrderItemsViewModel, opt => opt.Ignore());


            CreateMap<ProductViewModel, ProductDto>().ForMember(dest => dest.ReviewsDto, opt => opt.Ignore());
            CreateMap<ProductDto, ProductViewModel>().ForMember(dest => dest.ReviewsViewModel, opt => opt.Ignore());
        }
    }
}
