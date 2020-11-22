using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface ICategoryRepository
    {
        bool SaveChanges();
        public IEnumerable<Category> GetAllCategories();
        public Category GetCategoryById(int id);

        public void CreateCategory(Category category);

        public void UpdateCategory(Category category);

        public void RemoveCategory(Category category);
    }
}
