using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Models
{
    public class Menu
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [MaxLength(50)]
        [Display(Name = "Menu Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [MaxLength(100)]
        [Display(Name = "Special Note!")]
        public string Note { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<OrderMenu> OrderMenus { get; set; }


    }
}
