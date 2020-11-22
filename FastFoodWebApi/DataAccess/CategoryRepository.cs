using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Database;
using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FastFoodContext _db;
        public CategoryRepository(FastFoodContext db)
        {
            _db = db;
        }
        public void CreateCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            _db.Categories.Add(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _db.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            _db.Categories.Remove(category);
        }

        public bool SaveChanges()
        {
            return (_db.SaveChanges() >= 0);
        }

        public void UpdateCategory(Category category)
        {
            //
        }
    }
}
