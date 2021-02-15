using FastFoodWebApi.Controllers;
using System;
using Xunit;

namespace XUnitTestFastFoodApi
{
    public class UnitTest1
    {
        CategoryController category = new CategoryController();
        [Fact]
        public void GetReturnsCategory()
        {
            var returnCat = category.GetCategory(2);
            Assert.Equal("Drink", returnCat.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
