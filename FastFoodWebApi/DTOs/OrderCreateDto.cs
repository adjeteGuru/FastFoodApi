﻿using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public enum Status
    {
        InProcessing, OnItsWay, Delivered
    }
    public class OrderCreateDto
    {

        private DateTime? createAt = null;
        public DateTime CreateAt
        {
            get
            {
                return this.createAt.HasValue
                   ? this.createAt.Value
                   : DateTime.Now;
            }

            set { this.createAt = value; }
        }

        public int Quantity { get; set; }

        public int CustomerId { get; set; }


        public decimal DeliveryCharge { get; set; }
        public TimeSpan EstimateTime { get; set; }

        [MaxLength(50)]
        public string Alergy { get; set; }
        public Status Status { get; set; }
    }
}

