using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface IOrderRepository
    {
        bool SaveChanges();
        public Task<IEnumerable<Order>> GetAllOrders();
        public Task<Order> GetOrderById(int id);

        public void CreateOrder(Order order);
    }
}
