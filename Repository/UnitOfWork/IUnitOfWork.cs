using System;

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
