using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
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

        //public DateTime? CreateAt { get; set; }
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
        public DateTime DeliveryDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Status Status { get; set; }
    }
}
