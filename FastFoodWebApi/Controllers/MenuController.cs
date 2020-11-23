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
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;
        public MenuController(IMenuRepository menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }
        // GET: api/Menu
        [HttpGet]
        public ActionResult<IEnumerable<MenuReadDto>> GetAllMenus()
        {
            var menus = _menuRepository.GetAllMenus();

            return Ok(_mapper.Map<IEnumerable<MenuReadDto>>(menus));
        }

        // GET: api/Menu/5
        [HttpGet("{id}", Name = "GetMenu")]
        public ActionResult<MenuReadDto> GetMenu(int id)
        {
            var menu = _menuRepository.GetMenuById(id);

            if (menu == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MenuReadDto>(menu));
        }

        // POST: api/Menu
        [HttpPost]
        public ActionResult<MenuReadDto> CreateMenu(MenuCreateDto menuCreateDto)
        {
            var menuModel = _mapper.Map<Menu>(menuCreateDto);

            _menuRepository.CreateMenu(menuModel);
            _menuRepository.SaveChanges();

            var menuReadDto = _mapper.Map<MenuReadDto>(menuModel);

            return CreatedAtRoute(nameof(GetMenu), new { menuReadDto.Id }, menuReadDto);
        }

        // PUT: api/Menu/5
        [HttpPut("{id}")]
        public ActionResult<MenuUpdateDto> UpdateMenu(int id, MenuUpdateDto menuUpdateDto)
        {
            var menuModel = _menuRepository.GetMenuById(id);

            if (menuModel == null)
            {
                return NotFound();
            }

            var menuToUpdate = _mapper.Map(menuUpdateDto, menuModel);

            _menuRepository.UpdateMenu(menuToUpdate);
            _menuRepository.SaveChanges();

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult DeleteMenu(int id)
        {
            var menuModel = _menuRepository.GetMenuById(id);

            if (menuModel == null)
            {
                return NotFound();
            }

            _menuRepository.RemoveMenu(menuModel);

            _menuRepository.SaveChanges();

            return NoContent();
        }
    }
}
