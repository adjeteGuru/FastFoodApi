using FastFoodWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.Database
{
    public class FastFoodContext : DbContext
    {
        public FastFoodContext(DbContextOptions<FastFoodContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
