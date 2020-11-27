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

        [Required(ErrorMessage = "Please enter your name")]
        [MaxLength(50)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter contact number")]
        [MaxLength(11)]
        [Display(Name = "Telephone")]
        public string Tel { get; set; }

        [Display(Name = "Building Name")]
        [MaxLength(50)]
        public string BuildingName { get; set; }

        [MaxLength(10)]
        [Display(Name = "House No")]
        public string HouseNo { get; set; }

        [Required(ErrorMessage = "Please enter  street name")]
        [MaxLength(50)]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter postcode")]
        [MaxLength(10)]
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Please enter city")]
        [MaxLength(20)]
        [Display(Name = "City")]
        public string City { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
