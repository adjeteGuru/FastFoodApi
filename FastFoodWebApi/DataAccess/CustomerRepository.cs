using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess
{
    public class CustomerRepository : ICustomer
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
