using AutoMapper;
using FastFoodWebApi.Controllers;
using FastFoodWebApi.DataAccess;
using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestFastFoodApi
{
    public class CategoryTest
    {

        CategoryController _categoryController;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryTest(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _categoryController = new CategoryController(categoryRepository, mapper);
        }



        // [Fact]
        // public void Get_WhenCalled_ReturnsOkResult()
        // {

        //Act
        // var okResult = _categoryController.GetType();
        // CategoryController catControl = new CategoryController(_categoryRepository, _mapper);
        //var okResult = _categoryController.GetCategories();
        //CategoryRepository categoryRepository = catControl.GetCategory(2);
        //Mapper mapper = catControl<CategoryRepository>
        //Assert
        //Assert.IsType<OkObjectResult>(okResult.Result);
        // }

        // [Fact]
        // public void Get_WhenCalled_ReturnsAllItems()
        //{
        // Act            

        // var catListActual = _categoryController.GetCategories();           

        // Assert

        //var items = Assert.IsType<List<ShoppingItem>>(okResult.Value);            
        //var categoriesExpected = Assert.IsAssignableFrom<IEnumerable<CategoryReadDto>>(catListActual.Value);

        //Assert.Equal(categoriesExpected.ToList(), catListActual.Value);
        //}
    }
}
