using FastFoodWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFoodWebApi.DataAccess.Contracts
{
    public interface IOrderMenuRepository
    {
        bool SaveChanges();
        public IEnumerable<OrderMenu> GetAllOrderMenus();

        public OrderMenu GetOrderMenuById(int id);
        public void CreateOrderMenu(OrderMenu orderMenu);

        public void UpdateOrderMenu(OrderMenu orderMenu);
        public void RemoveOrderMenu(OrderMenu orderMenu);
    }
}
