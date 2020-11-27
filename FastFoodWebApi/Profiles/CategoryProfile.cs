using AutoMapper;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            //source ---> destination
            CreateMap<Category, CategoryReadDto>();

            CreateMap<CategoryCreateDto, Category>();

            CreateMap<CategoryUpdateDto, Category>();

            CreateMap<Category, CategoryUpdateDto>();
        }



    }
}
