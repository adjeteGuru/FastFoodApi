using FastFoodWebApi.DataAccess.Contracts;
using FastFoodWebApi.Database;
using FastFoodWebApi.Models;
using Microsoft.EntityFrameworkCore;
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
            _db = db ?? throw new ArgumentNullException(nameof(_db));
        }
        public void CreateCategory(Category category)
        {
            //if (category == null)
            //{
            //    throw new ArgumentNullException(nameof(category));
            //}

            _db.Categories.Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _db.Categories
                .Include(x => x.Menus)
                .ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _db.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveCategory(Category category)
        {
            //if (category == null)
            //{
            //    throw new ArgumentNullException(nameof(category));
            //}

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
