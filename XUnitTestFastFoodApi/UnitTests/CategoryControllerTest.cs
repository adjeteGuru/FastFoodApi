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
        private readonly CategoryController _controller;
        private readonly Mock<ICategoryRepository> _mockRepo;
        private readonly Mock<IMapper> _mockMapper;  
        
        public CategoryControllerTest()
        {
            _mockRepo = new Mock<ICategoryRepository>();
            _mockMapper = new Mock<IMapper>();
            _controller = new CategoryController(_mockRepo.Object, _mockMapper.Object);
        }

        [Fact]
        public void GetCategories_ShouldReturnAllCategoriesList()
        {         
           
            var result = _controller.GetAllCategories();

            //Assert            
            var expected = Assert.IsAssignableFrom<ActionResult<IEnumerable<CategoryReadDto>>>(result);

            Assert.Equal(expected.Value, result.Value);            

        }
    }
}
