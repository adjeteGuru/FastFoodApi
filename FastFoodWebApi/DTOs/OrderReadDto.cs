﻿using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public class OrderReadDto
    {
        public int Id { get; set; }

        public DateTime? CreateAt { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public float DeliveryCharge { get; set; }
        public TimeSpan EstimateTime { get; set; }

        [MaxLength(50)]
        public string Alergy { get; set; }

        public Status Status { get; set; }

        //public ICollection<OrderMenu> OrderMenus { get; set; }

    }
}
