using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Models
{
    public class OrderMenu
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

    }
}
