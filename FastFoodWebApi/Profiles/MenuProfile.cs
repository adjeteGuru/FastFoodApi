using AutoMapper;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Profiles
{
    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            // source ---> destination
            CreateMap<Menu, MenuReadDto>();

            CreateMap<MenuCreateDto, Menu>();

            CreateMap<MenuUpdateDto, Menu>();

            CreateMap<Menu, MenuUpdateDto>();
        }
    }
}
