using AutoMapper;
using OCS.DTO;
using OCS.ViewModel.Order;
using OCS.ViewModel.OrderItem;
using OCS.ViewModel.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Profiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderViewModel, OrderDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItemsViewModel));
            CreateMap<OrderDto, OrderViewModel>().ForMember(dest => dest.OrderItemsViewModel, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<OrderViewModel, OrderDto>().ForMember(dest => dest.PaymentsDto, opt => opt.MapFrom(src => src.PaymentsViewModel));
            CreateMap<OrderDto, OrderViewModel>().ForMember(dest => dest.PaymentsViewModel, opt => opt.MapFrom(src => src.PaymentsDto));



            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.OrderDto, opt => opt.MapFrom(src => src.OrderViewModel));
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.OrderViewModel, opt => opt.MapFrom(src => src.OrderDto));

            CreateMap<OrderItemViewModel, OrderItemDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.ProductViewModel));
            CreateMap<OrderItemDto, OrderItemViewModel>().ForMember(dest => dest.ProductViewModel, opt => opt.MapFrom(src => src.ProductDto));


            CreateMap<PaymentViewModel, PaymentDto>().ForMember(dest => dest.OrderDto, opt => opt.Ignore());
            CreateMap<PaymentDto, PaymentViewModel>().ForMember(dest => dest.OrderViewModel, opt => opt.Ignore());
        }
    }
}
