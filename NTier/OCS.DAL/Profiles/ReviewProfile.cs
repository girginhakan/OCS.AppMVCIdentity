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
    public class ReviewProfile:Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewDto>().ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.Product));
            CreateMap<ReviewDto, Review>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.ProductDto));



            CreateMap<Product, ProductDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<ProductDto, Product>().ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.OrderDto, opt => opt.Ignore());
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Order, opt => opt.Ignore());
            //eksik
        }
    }
}
