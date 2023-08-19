using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository.Implementation
{
    public class Order_ItemRepository : GenericRepository<Order_Item>, IOrder_ItemRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public Order_ItemRepository(RepositoryContext context) : base(context)
        {
            _repositoryContext = context;
        }

        public Order_Item GetOrderItemByFoodId(int id)
        {
            var orderItem = _repositoryContext.Order_Items.FirstOrDefault(x => x.FoodId == id);
            return orderItem;
        }

        public Order_Item GetOrderItemByHotDrinksId(int id)
        {
            var orderItem = _repositoryContext.Order_Items.FirstOrDefault(x => x.HotDrinkId == id);
            return orderItem;
        }

        public Order_Item GetOrderItemByColdDrinksId(int id)
        {
            var orderItem = _repositoryContext.Order_Items.FirstOrDefault(x => x.ColdDrinkId == id);
            return orderItem;
        }
    }
}
