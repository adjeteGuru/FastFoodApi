using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface IMenuRepository
    {
        bool SaveChanges();
        public IEnumerable<Menu> GetAllMenus();

        public Menu GetMenuById(int id);

        public void CreateMenu(Menu menu);

        public void UpdateMenu(Menu menu);

        public void RemoveMenu(Menu menu);
    }
}
