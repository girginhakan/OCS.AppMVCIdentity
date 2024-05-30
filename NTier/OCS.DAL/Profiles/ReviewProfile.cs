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
            CreateMap<Review, ReviewDto>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));
            CreateMap<ReviewDto, Review>().ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));

            //eksik
        }
    }
}
