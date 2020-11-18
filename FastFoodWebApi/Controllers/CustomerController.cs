using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.DTOs;
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
        //argument that will allow object Automapper injection
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        // GET: api/Customer
        [HttpGet]
        public ActionResult<IEnumerable<CustomerReadDto>> GetCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();

            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customers));
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "GetCustomer")]
        //we want to retun ActionResult through CustomerReadDto
        public ActionResult<IEnumerable<CustomerReadDto>> GetCustomer(int? id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            };

            //map into our CustomerReadDto and from customer
            return Ok(_mapper.Map<CustomerReadDto>(customer));
        }

        // POST: api/Customer
        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            //create on object from Dto to mappe it to Model
            var customerModel = _mapper.Map<Customer>(customerCreateDto);

            _customerRepository.CreateCustomer(customerModel);
            _customerRepository.SaveChanges();

            //
            var customerReadDto = _mapper.Map<CustomerReadDto>(customerModel);

            //return Ok(customerModel);
            //retun CreateAtRoute in the name of our method (GetCustomer) that retrieve a single customer
            //then create Anonymous new customer object then pass back 
            return CreatedAtRoute(nameof(GetCustomer), new { customerReadDto.Id }, customerReadDto);
        }

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
