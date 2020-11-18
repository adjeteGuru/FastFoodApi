using AutoMapper;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Profiles
{
    //this inherited class allow both Models class and DTO class to share 
    //between a source object and a domain(destination) object
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerReadDto>();
        }
    }
}
