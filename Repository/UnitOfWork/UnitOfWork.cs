using CoffeeShopApp.Models.DatabaseContext;
using CoffeeShopApp.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext _context;
        public UnitOfWork(RepositoryContext context)
        {
            _context = context;
            ColdDrinks = new ColdDrinksRepository(_context);
            HotDrinks = new HotDrinksRepository(_context);
            Foods = new FoodRepository(_context);
            Order_Items = new Order_ItemRepository(_context);
            Orders = new OrderRepository(_context);
            Users = new UserRepository(_context);

        }

        public IColdDrinksRepository ColdDrinks { get; private set; }

        public IHotDrinksRepository HotDrinks { get; private set; }

        public IFoodRepository Foods { get; private set; }

        public IOrder_ItemRepository Order_Items { get; private set; }

        public IOrderRepository Orders { get; private set; }

        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
