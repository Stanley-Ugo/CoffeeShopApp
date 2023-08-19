using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;

namespace CoffeeShopApp.Repository.Implementation
{
    public class HotDrinksRepository : GenericRepository<HotDrink>, IHotDrinksRepository
    {
        public HotDrinksRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
