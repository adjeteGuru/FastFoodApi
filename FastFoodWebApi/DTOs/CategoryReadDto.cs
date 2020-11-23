using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public class CategoryReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}
