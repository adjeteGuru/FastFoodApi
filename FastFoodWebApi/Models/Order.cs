using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Models
{
    public class Order
    {
        public int Id { get; set; }


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

        [Required]
        public int Quantity { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
