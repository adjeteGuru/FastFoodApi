using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface ICustomerRepository
    {
        bool SaveChanges();
        public IEnumerable<Customer> GetAllCustomers();
        public Customer GetCustomerById(int? id);

        public void CreateCustomer(Customer customer);
    }
}
