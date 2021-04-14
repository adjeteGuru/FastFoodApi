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
        [Fact]
        public void GetCategories_ShouldReturnAllCategoriesList()
        {           

            //Arrange

            //TO DO:
            //Here I need the mocking library to inject a mock object through DI
            //Them I need to new up the controller to be tested

           
            var mockRepo = new Mock<ICategoryRepository>();
            mockRepo.Setup(c => c.GetCategories())             
                .Returns((IEnumerable<Category>)new CategoryReadDto[]
                {
                    new CategoryReadDto {Id= 1, Name= "Drink"},
                    new CategoryReadDto {Id= 2, Name ="Kebab"}
                }.AsEnumerable());

            var mockMapper = new Mock<IMapper>();
            mockMapper.Setup(m => m.Map<IEnumerable<Category>>(mockMapper))            
                 .Returns(new Category[]
                 {
                     new Category {Id = 1, Name = "Drink"},
                     new Category {Id = 2, Name = "Kebab"}
                 }.AsEnumerable());              


            var controller = new CategoryController(mockRepo.Object, mockMapper.Object);

            //Act
            var actual = controller.GetAllCategories();
            

            //Assert
            var expected = Assert.IsAssignableFrom<IEnumerable<CategoryReadDto>>(actual);            


             Assert.Equal(expected, actual.Value);
            
               
        }
    }
}
