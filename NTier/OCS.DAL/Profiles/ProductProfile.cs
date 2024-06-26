﻿using AutoMapper;
using OCS.DTO;
using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ForMember(dest => dest.CategoryDto, opt => opt.MapFrom(src => src.Category));
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.CategoryDto));

            CreateMap<Product, ProductDto>().ForMember(dest => dest.OrderItemsDto, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<ProductDto, Product>().ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItemsDto));

            CreateMap<Product, ProductDto>().ForMember(dest => dest.ReviewsDto, opt => opt.MapFrom(src => src.Reviews));
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.ReviewsDto));






            CreateMap<Category, CategoryDto>().ForMember(dest => dest.ProductsDto, opt => opt.Ignore());
            CreateMap<CategoryDto, Category>().ForMember(dest => dest.Products, opt => opt.Ignore());

            CreateMap<OrderItem,OrderItemDto>().ForMember(dest=>dest.ProductDto,opt=> opt.Ignore());
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest=>dest.Product,opt=> opt.Ignore());


            CreateMap<OrderItem, OrderItemDto>().ForMember(dest => dest.OrderDto, opt => opt.MapFrom(src => src.Order));
            CreateMap<OrderItemDto, OrderItem>().ForMember(dest => dest.Order, opt => opt.MapFrom(src=>src.OrderDto));


            CreateMap<Review,ReviewDto>().ForMember(dest=>dest.ProductDto,opt=> opt.MapFrom(src => src.Product));
            CreateMap<ReviewDto, Review>().ForMember(dest=>dest.Product,opt=> opt.MapFrom(src => src.ProductDto));
        }
    }
}
