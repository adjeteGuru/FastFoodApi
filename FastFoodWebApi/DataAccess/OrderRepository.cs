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

        public void CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _db.Orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _db.Orders.Remove(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = _db.Orders
                .Include(x => x.Customer)
                .ToList();
            return orders;
        }

        public Order GetOrderById(int? id)
        {
            return _db.Orders
                .Include(x => x.Customer)
                .FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_db.SaveChanges() >= 0);
        }

        public void UpdateOrder(Order order)
        {
            //throw new NotImplementedException();
        }
    }
}
