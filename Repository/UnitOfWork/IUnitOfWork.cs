using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IColdDrinksRepository ColdDrinks { get; }
        IHotDrinksRepository HotDrinks { get; }
        IFoodRepository Foods { get; }
        IOrder_ItemRepository Order_Items { get; }
        IOrderRepository Orders { get; }
        IUserRepository Users { get; }
        int Complete();
    }
}
