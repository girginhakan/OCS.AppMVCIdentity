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
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>().ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<OrderDto, Order>().ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));

            CreateMap<Order,OrderDto>().ForMember(dest=>dest.Payments,opt=>opt.MapFrom(src => src.Payments));
            CreateMap<OrderDto,Order>().ForMember(dest=>dest.Payments,opt=>opt.MapFrom(src => src.Payments));



            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.Order, opt => opt.Ignore());
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Order, opt => opt.Ignore());


            CreateMap<Payment, PaymentDto>().ForMember(dest => dest.Order, opt => opt.Ignore());
            CreateMap<PaymentDto, Payment>().ForMember(dest => dest.Order, opt => opt.Ignore());
        }
    }
}
