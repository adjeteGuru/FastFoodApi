using AutoMapper;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Profiles
{
    public class OrderMenuProfile : Profile
    {
        public OrderMenuProfile()
        {
            //source ---destination
            CreateMap<OrderMenu, OrderMenuReadDto>();

            CreateMap<OrderMenuCreateDto, OrderMenu>();

            CreateMap<OrderMenuUpdateDto, OrderMenu>();
        }
    }
}
