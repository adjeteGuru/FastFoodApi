using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastFoodWebApi.Database;
using FastFoodWebApi.Models;
using FastFoodWebApi.DataAccess.Contracts;
using AutoMapper;
using FastFoodWebApi.DTOs;
using Microsoft.AspNetCore.JsonPatch;

namespace FastFoodWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        //GET: api/Order
        [HttpGet]
        public ActionResult<IEnumerable<OrderReadDto>> GetOrders()
        {
            var orders = _orderRepository.GetAllOrders();

            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(orders));

        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public ActionResult<OrderReadDto> GetOrder(int? id)
        {

            var order = _orderRepository.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderReadDto>(order));
        }


        // POST: api/Order/5
        [HttpPost]
        public ActionResult<OrderReadDto> CreateOrder(OrderCreateDto orderCreateDto)
        {
            //create an object Model that is the result of a created mapped object  
            var orderModel = _mapper.Map<Order>(orderCreateDto);

            if (orderModel == null)
            {
                return NotFound();
            }

            _orderRepository.CreateOrder(orderModel);

            _orderRepository.SaveChanges();

            var orderReadDto = _mapper.Map<OrderReadDto>(orderModel);

            return CreatedAtRoute(nameof(GetOrder), new { orderReadDto.Id }, orderReadDto);

        }

        // PUT: api/Order/5       
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, OrderUpdateDto orderUpdateDto)
        {
            var oderToUpdate = _orderRepository.GetOrderById(id);

            if (oderToUpdate == null)
            {
                return NotFound();
            }

            var orderModel = _mapper.Map(orderUpdateDto, oderToUpdate);

            _orderRepository.UpdateOrder(orderModel);

            _orderRepository.SaveChanges();

            return NoContent();
        }


        // PATCH: api/Order/5 
        [HttpPatch("{id}")]
        public ActionResult PartialOrderUpdate(int id, JsonPatchDocument<OrderUpdateDto> patchDoc)
        {
            var oderToUpdate = _orderRepository.GetOrderById(id);

            if (oderToUpdate == null)
            {
                return NotFound();
            }


            var orderToPatch = _mapper.Map<OrderUpdateDto>(oderToUpdate);

            patchDoc.ApplyTo(orderToPatch, ModelState);

            if (!TryValidateModel(patchDoc))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(orderToPatch, oderToUpdate);

            _orderRepository.SaveChanges();
            return NoContent();

        }

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(int id)
        {
            var orderToDelete = _orderRepository.GetOrderById(id);

            if (orderToDelete == null)
            {
                return NotFound();
            }

            _orderRepository.DeleteOrder(orderToDelete);

            _orderRepository.SaveChanges();

            return NoContent();
        }

    }
}
