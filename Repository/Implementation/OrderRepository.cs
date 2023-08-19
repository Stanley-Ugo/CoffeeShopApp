using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;

namespace CoffeeShopApp.Repository.Implementation
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
