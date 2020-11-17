using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetAllCustomers();
        public Customer GetCustomerById(int id);
    }
}
