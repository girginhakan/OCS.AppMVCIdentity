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
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {

            CreateMap<Category, CategoryDto>().ForMember(dest => dest.ProductsDto, opt => opt.MapFrom(src => src.Products));
            CreateMap<CategoryDto,Category>().ForMember(dest=>dest.Products,opt=>opt.MapFrom(src => src.ProductsDto));





            CreateMap<Product, ProductDto>().ForMember(dest => dest.CategoryDto, opt => opt.Ignore());
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Category, opt => opt.Ignore());

            CreateMap<Product,ProductDto>().ForMember(dest=>dest.OrderItemsDto, opt => opt.Ignore());
            CreateMap<ProductDto, Product>().ForMember(dest=>dest.OrderItems, opt => opt.Ignore());

            CreateMap<ProductDto, Product>().ForMember(dest=>dest.Reviews, opt => opt.MapFrom(src=>src.ReviewsDto));
            CreateMap<Product, ProductDto>().ForMember(dest=>dest.ReviewsDto, opt => opt.MapFrom(src => src.Reviews));



            CreateMap<CategoryDto,Category>().ReverseMap();

        }
    }
}
