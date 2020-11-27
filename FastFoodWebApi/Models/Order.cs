using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Models
{
    public enum Status
    {
        InProcessing, OnItsWay, Delivered
    }
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


        [Display(Name = "Delivery Charge")]
        public decimal DeliveryCharge { get; set; }

        [Display(Name = "Estimate time")]
        public TimeSpan EstimateTime { get; set; }

        [MaxLength(50)]
        [Display(Name = "Alergy to!")]
        public string Alergy { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Status Status { get; set; }

        public ICollection<OrderMenu> OrderMenus { get; set; }
    }
}
