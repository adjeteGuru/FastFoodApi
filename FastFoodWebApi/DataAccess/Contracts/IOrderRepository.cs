using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface IOrderRepository
    {
        public Task<IEnumerable<Order>> GetAllOrders();
        public Task<Order> GetOrderById(int id);
    }
}
