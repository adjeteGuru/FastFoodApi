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

        public void CreateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _db.Customers.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _db.Customers.Remove(customer);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public Customer GetCustomerById(int? id)
        {
            return _db.Customers.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_db.SaveChanges() >= 0);
        }

        public void UpdateCustomer(Customer customer)
        {
            //for update do notting

        }
    }
}
