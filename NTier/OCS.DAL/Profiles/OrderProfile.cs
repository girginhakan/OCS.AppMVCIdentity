using AutoMapper;
using OCS.DTO;
using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<OrderDto, Order>().ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<Order, OrderDto>().ForMember(dest => dest.PaymentsDto, opt => opt.MapFrom(src => src.Payments));
            CreateMap<OrderDto, Order>().ForMember(dest => dest.Payments, opt => opt.MapFrom(src => src.PaymentsDto));



            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.OrderDto, opt => opt.MapFrom(src => src.Order));
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.OrderDto));

            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.Product));
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.ProductDto));


            CreateMap<Payment, PaymentDto>().ForMember(dest => dest.OrderDto, opt => opt.Ignore());
            CreateMap<PaymentDto, Payment>().ForMember(dest => dest.Order, opt => opt.Ignore());
        }
    }
}
