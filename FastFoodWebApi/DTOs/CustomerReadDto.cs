using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DTOs
{
    public class CustomerReadDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Tel { get; set; }
        public string BuildingName { get; set; }

        public string HouseNo { get; set; }

        public string Street { get; set; }

        public string Postcode { get; set; }

        public string City { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
