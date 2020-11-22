using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public class OrderMenuCreateDto
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }

        [Required]
        public int Quantity { get; set; }

    }
}
