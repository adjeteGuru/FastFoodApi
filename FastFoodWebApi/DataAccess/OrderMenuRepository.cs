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
    public class OrderMenuRepository : IOrderMenuRepository
    {
        private readonly FastFoodContext _db;
        public OrderMenuRepository(FastFoodContext db)
        {
            _db = db;
        }
        public void CreateOrderMenu(OrderMenu orderMenu)
        {
            if (orderMenu == null)
            {
                throw new ArgumentNullException(nameof(orderMenu));
            }
            _db.OrderMenus.Add(orderMenu);
        }

        public IEnumerable<OrderMenu> GetAllOrderMenus()
        {
            return _db.OrderMenus
                .Include(x => x.Menu)
                .Include(x => x.Order)
                .ToList();
        }

        public OrderMenu GetOrderMenuById(int id)
        {
            return _db.OrderMenus
                .Include(x => x.Menu)
                .Include(x => x.Order)
                .FirstOrDefault(x => x.Id == id);
            //.FirstOrDefault(x => x.MenuId == id || x.OrderId == id);
        }

        public void RemoveOrderMenu(OrderMenu orderMenu)
        {
            if (orderMenu == null)
            {
                throw new ArgumentNullException(nameof(orderMenu));
            }

            _db.OrderMenus.Remove(orderMenu);
        }

        public bool SaveChanges()
        {
            return (_db.SaveChanges() >= 0);
        }

        public void UpdateOrderMenu(OrderMenu orderMenu)
        {
            //
        }
    }
}
