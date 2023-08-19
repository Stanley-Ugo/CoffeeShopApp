using CoffeeShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository
{
    public interface IOrder_ItemRepository : IGenericRepository<Order_Item>
    {
        public Order_Item GetOrderItemByFoodId(int id);
        public Order_Item GetOrderItemByHotDrinksId(int id);
        public Order_Item GetOrderItemByColdDrinksId(int id);
    }
}
