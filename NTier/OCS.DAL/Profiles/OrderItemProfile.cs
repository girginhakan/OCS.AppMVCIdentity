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
    public class OrderItemProfile : Profile
    {
        public OrderItemProfile()
        {
            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order));
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.Order));

            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));



            CreateMap<Order, OrderDto>().ForMember(dest => dest.Payments, opt => opt.Ignore());
            CreateMap<OrderDto, Order>().ForMember(dest => dest.Payments, opt => opt.Ignore());

            CreateMap<Product, ProductDto>().ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews));
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews));

            CreateMap<Review, ReviewDto>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));
            CreateMap<ReviewDto, Review>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));
        }
    }
}
