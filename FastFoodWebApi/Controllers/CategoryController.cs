using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastFoodWebApi.DataAccess;
using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Database;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {        
        private ICategoryRepository _categoryRepository;
        private IMapper _mapper;     

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository /*?? throw new ArgumentNullException(nameof(_categoryRepository))*/;
            _mapper = mapper/* ?? throw new ArgumentNullException(nameof(_mapper))*/;
        }



        // GET: api/Category
        [HttpGet]
        public ActionResult<IEnumerable<CategoryReadDto>> GetAllCategories()
        {
            var category = _categoryRepository.GetCategories();

            return Ok(_mapper.Map<IEnumerable<CategoryReadDto>>(category));
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public ActionResult<CategoryReadDto> GetCategory(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryReadDto>(category));
        }

        // POST: api/Category
        [HttpPost]
        public ActionResult<CategoryReadDto> CreateCategory(CategoryCreateDto categoryCreateDto)
        {            
            var categoryModel = _mapper.Map<Category>(categoryCreateDto);

            _categoryRepository.CreateCategory(categoryModel);

            _categoryRepository.SaveChanges();

            var categoryReadDto = _mapper.Map<CategoryReadDto>(categoryModel);

            return CreatedAtAction(nameof(GetCategory), new { categoryReadDto.Id }, categoryReadDto);

        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public ActionResult<CategoryReadDto> UpdateCategory(int id, CategoryUpdateDto categoryUpdateDto)
        {
            var category = _categoryRepository.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            var categoryToUpdate = _mapper.Map(categoryUpdateDto, category);

            _categoryRepository.UpdateCategory(categoryToUpdate);

            _categoryRepository.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }
            _categoryRepository.RemoveCategory(category);
            _categoryRepository.SaveChanges();
            return NoContent();
        }
    }
}
