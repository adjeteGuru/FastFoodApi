using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/Customer
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            return Ok(customers);
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Customer>> GetCustomer(int? id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (id == null)
            {
                return NotFound();
            };

            return Ok(customer);
        }

        //// POST: api/Customer
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Customer/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
