using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public class OrderMenuReadDto
    {
        //public int OrderId { get; set; }
        //public int MenuId { get; set; }
        //public int Quantity { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int Quantity { get; set; }

    }
}
