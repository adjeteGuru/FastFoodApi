using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public class OrderReadDto
    {
        public int Id { get; set; }

        public DateTime? CreateAt { get; set; }

        public int Quantity { get; set; }

        public DateTime DeliveryDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Status Status { get; set; }

    }
}
