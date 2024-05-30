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
    public class PaymentProfile:Profile
    {
        public PaymentProfile()
        {
            CreateMap<Payment, PaymentDto>().ForMember(dest => dest.OrderDto, opt => opt.MapFrom(src => src.Order));
            CreateMap<PaymentDto, Payment>().ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.OrderDto));


            //---------------------------------


            CreateMap<Order, OrderDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<OrderDto, Order>().ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.Product));
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.ProductDto));




            CreateMap<Product, ProductDto>().ForMember(dest => dest.CategoryDto, opt => opt.Ignore());
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Category, opt => opt.Ignore());

            CreateMap<Product, ProductDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.Ignore());
            CreateMap<ProductDto, Product>().ForMember(dest => dest.OrderItems, opt => opt.Ignore());


            CreateMap<Product, ProductDto>().ForMember(dest => dest.ReviewsDto, opt => opt.Ignore());
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Reviews, opt => opt.Ignore());
        }
    }
}
