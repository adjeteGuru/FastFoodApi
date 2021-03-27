using AutoMapper;
using FastFoodWebApi.Controllers;
using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.DTOs;
using FastFoodWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitTestFastFoodApi.UnitTests
{
    public class CategoryControllerTest
    {
        CategoryController _controller;
        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public CategoryControllerTest(ICategoryRepository categoryRepo, IMapper mapper)
        {            
             _controller = new CategoryController(categoryRepo, mapper);
        }
        [Fact]
        public void GetCategories_ShouldReturnAllCategoriesList()
        {           

            //Arrange

            //TO DO:
            //Here I need the mocking library to inject a mock object through DI
            //Them I need to new up the controller to be tested

           
            var mockCategoryRepo = new Mock<ICategoryRepository>();
            mockCategoryRepo.Setup(c => c.GetCategories())
                .Returns((IEnumerable<Category>)mockCategoryRepo);
                

            var mockMapper = new Mock<IMapper>();
            mockMapper.Setup(m => m.Map<IEnumerable<CategoryReadDto>>(mockMapper));          

            var controllerTest = new CategoryController(mockCategoryRepo.Object, mockMapper.Object);

            //Act
            var resultD = controllerTest.GetAllCategories();

            //Assert
            var viewResult = Assert.IsAssignableFrom<IEnumerable<CategoryReadDto>>(resultD);        
                        
                Assert.Equal(viewResult, resultD.Value);
               
        }
    }
}
