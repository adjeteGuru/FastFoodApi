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
    public class OrderMenuController : ControllerBase
    {
        private readonly IOrderMenuRepository _orderMenuRepository;
        private readonly IMapper _mapper;
        public OrderMenuController(IOrderMenuRepository orderMenuRepository, IMapper mapper)
        {
            _orderMenuRepository = orderMenuRepository;
            _mapper = mapper;
        }
        // GET: api/OrderMenu
        [HttpGet]
        public ActionResult<IEnumerable<OrderMenuReadDto>> GetOrderMenus()
        {
            var orderMenu = _orderMenuRepository.GetAllOrderMenus();

            return Ok(_mapper.Map<IEnumerable<OrderMenuReadDto>>(orderMenu));
        }

        // GET: api/OrderMenu/5
        [HttpGet("{id}", Name = "GetOrderMenu")]
        public ActionResult<OrderMenuReadDto> GetOrderMenu(int id)
        {
            var orderMenu = _orderMenuRepository.GetOrderMenuById(id);

            if (orderMenu == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderMenuReadDto>(orderMenu));
        }

        // POST: api/OrderMenu
        [HttpPost]
        public ActionResult<OrderMenuReadDto> CreateOrderMenu(OrderMenuCreateDto orderMenuCreateDto)
        {
            var orderMenuModel = _mapper.Map<OrderMenu>(orderMenuCreateDto);
            _orderMenuRepository.CreateOrderMenu(orderMenuModel);
            _orderMenuRepository.SaveChanges();

            var orderMenuReadDto = _mapper.Map<OrderMenuReadDto>(orderMenuModel);

            return CreatedAtAction(nameof(GetOrderMenu), new { orderMenuCreateDto.OrderId }, orderMenuCreateDto);
        }

        // PUT: api/OrderMenu/5
        [HttpPut("{id}")]
        public ActionResult UpdateOrderMenu(int id, OrderMenuUpdateDto orderMenuUpdateDto)
        {
            var orderMenuModel = _orderMenuRepository.GetOrderMenuById(id);

            if (orderMenuModel == null)
            {
                return NotFound();
            }

            var orderMenuToUpdate = _mapper.Map(orderMenuUpdateDto, orderMenuModel);

            _orderMenuRepository.UpdateOrderMenu(orderMenuToUpdate);

            _orderMenuRepository.SaveChanges();

            return NoContent();

        }

        // DELETE: api/OrderMenu/5
        [HttpDelete("{id}")]
        public ActionResult DeleteOrderMenu(int id)
        {
            var orderMenuModel = _orderMenuRepository.GetOrderMenuById(id);

            if (orderMenuModel == null)
            {
                return NotFound();
            }

            _orderMenuRepository.RemoveOrderMenu(orderMenuModel);

            _orderMenuRepository.SaveChanges();

            return NoContent();
        }
    }
}
