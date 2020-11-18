using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Database;
using FastFoodWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FastFoodContext _db;

        //constructor dependency injection
        public OrderRepository(FastFoodContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            var orders = await _db.Orders
                .Include(x => x.CustomerId)
                .ToListAsync();
            return orders;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _db.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
