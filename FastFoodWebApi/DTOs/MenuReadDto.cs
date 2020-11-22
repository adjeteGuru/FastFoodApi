using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public class MenuReadDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public float Price { get; set; }

        [MaxLength(100)]
        public string Note { get; set; }

        public int CategoryId { get; set; }
    }
}
