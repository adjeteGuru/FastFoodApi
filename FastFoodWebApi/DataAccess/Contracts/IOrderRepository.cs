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
        public IEnumerable<Order> GetAllOrders();
        public Order GetOrderById(int? id);

        public void CreateOrder(Order order);

        public void UpdateOrder(Order order);

        public void DeleteOrder(Order order);
    }
}
