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
    public class MenuRepository : IMenuRepository
    {
        private readonly FastFoodContext _db;
        public MenuRepository(FastFoodContext db)
        {
            _db = db;
        }
        public void CreateMenu(Menu menu)
        {
            if (menu == null)
            {
                throw new ArgumentNullException(nameof(menu));
            }
            _db.Menus.Add(menu);
        }

        public IEnumerable<Menu> GetAllMenus()
        {
            return _db.Menus.ToList();

        }

        public Menu GetMenuById(int id)
        {
            return _db.Menus.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveMenu(Menu menu)
        {
            if (menu == null)
            {
                throw new ArgumentNullException(nameof(menu));
            }
            _db.Menus.Remove(menu);

        }

        public bool SaveChanges()
        {

            return (_db.SaveChanges() >= 0);
        }

        public void UpdateMenu(Menu menu)
        {
            //
        }
    }
}
