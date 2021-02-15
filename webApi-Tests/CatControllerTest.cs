using AutoMapper;
using FastFoodWebApi.Controllers;
using FastFoodWebApi.DataAccess;
using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace webApi_Tests
{
    public class CatControllerTest
    {
        //private readonly ICategoryRepository _categoryRepository;
        //private readonly IMapper _mapper;
        //CategoryController _categoryController;
        //ICategoryRepository _categoryRepository;
        //IMapper _mapper;

        //public CatControllerTest(/*ICategoryRepository categoryRepository, IMapper mapper*/)
        //{
        //_categoryRepository = new CategoryRepository();
        //_mapper = mapper;
        // _categoryController = new CategoryController(_categoryRepository, _mapper);
        // }


        // [Fact]
        // public void Get_WhenCalled_ReturnsOkResult()
        // {
        // Act
        //  var okResult = _categoryController.GetType();

        // Assert
        //  Assert.IsType<OkObjectResult>(okResult.Result);
        // }

        //[Fact]
        //public void Get_WhenCalled_ReturnsAllItems()
        //{
        //    // Act
        //    var okResult = _categoryController.GetType().Result as OkObjectResult;
        //    // Assert
        //    //var items = Assert.IsType<List<ShoppingItem>>(okResult.Value);
        //    var categories = Assert.IsAssignableFrom<IEnumerable<Category>>(okResult.Value);
        //    Assert.Equal(pizza, categories.ToList());
        //}
    }
}
