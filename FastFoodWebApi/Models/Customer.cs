using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }


        [MaxLength(10)]
        public string HouseNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Street { get; set; }

        [Required]
        [MaxLength(10)]
        public string Postcode { get; set; }

        [Required]
        [MaxLength(20)]
        public string City { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
