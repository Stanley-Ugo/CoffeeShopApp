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
        public Order_ItemRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
