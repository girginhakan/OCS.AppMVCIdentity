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

            CreateMap<Category, CategoryDto>().ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
            CreateMap<CategoryDto,Category>().ForMember(dest=>dest.Products,opt=>opt.MapFrom(src => src.Products));





            CreateMap<Product, ProductDto>().ForMember(dest => dest.Category, opt => opt.Ignore());
            CreateMap<ProductDto, Product>().ForMember(dest => dest.Category, opt => opt.Ignore());

            CreateMap<Product,ProductDto>().ForMember(dest=>dest.OrderItems, opt => opt.Ignore());
            CreateMap<ProductDto, Product>().ForMember(dest=>dest.OrderItems, opt => opt.Ignore());

            CreateMap<ProductDto, Product>().ForMember(dest=>dest.Reviews, opt => opt.MapFrom(src=>src.Reviews));
            CreateMap<Product, ProductDto>().ForMember(dest=>dest.Reviews, opt => opt.MapFrom(src => src.Reviews));

            CreateMap<Review,ReviewDto>().ForMember(dest=>dest.Product, opt => opt.MapFrom(src => src.Product));
            CreateMap<ReviewDto, Review>().ForMember(dest=>dest.Product, opt => opt.MapFrom(src => src.Product));

            CreateMap<CategoryDto,Category>().ReverseMap();

        }
    }
}
