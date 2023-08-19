using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;

namespace CoffeeShopApp.Repository.Implementation
{
    public class ColdDrinksRepository : GenericRepository<ColdDrink>, IColdDrinksRepository
    {
        public ColdDrinksRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
