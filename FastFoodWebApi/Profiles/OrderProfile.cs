using AutoMapper;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            //source ---> destination
            CreateMap<Order, OrderReadDto>();

            CreateMap<OrderCreateDto, Order>();

            CreateMap<OrderUpdateDto, Order>();

            CreateMap<Order, OrderUpdateDto>();
        }
    }
}
