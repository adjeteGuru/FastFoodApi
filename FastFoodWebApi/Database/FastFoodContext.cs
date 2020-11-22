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
        public DbSet<Menu> Menus { get; set; }
        public DbSet<OrderMenu> OrderMenus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderMenu>()
                .HasKey(t => new { t.OrderId, t.MenuId });

            modelBuilder.Entity<OrderMenu>()
                .HasOne(pt => pt.Order)
                .WithMany(p => p.OrderMenus)
                .HasForeignKey(pt => pt.OrderId);

            modelBuilder.Entity<OrderMenu>()
                .HasOne(pt => pt.Menu)
                 .WithMany(t => t.OrderMenus)
                .HasForeignKey(pt => pt.MenuId);

        }

    }
}
