using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Database;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly FastFoodContext _db;
        public CustomerRepository(FastFoodContext db)
        {
            _db = db;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public Customer GetCustomerById(int? id)
        {
            return _db.Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
