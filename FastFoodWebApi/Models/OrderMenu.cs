using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Models
{
    public class OrderMenu
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        [Required(ErrorMessage = "Please choose quantity")]
        [Display(Name = "Quatity")]
        public int Quantity { get; set; }

    }
}
