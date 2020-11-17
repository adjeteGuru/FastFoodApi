using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess
{
    public class OrderRepository : IOrder
    {
        public IEnumerable<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
