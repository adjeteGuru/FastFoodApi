﻿using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface IOrder
    {
        public IEnumerable<Order> GetAllOrders();
        public Order GetOrderById(int id);
    }
}
