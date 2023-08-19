using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;

namespace CoffeeShopApp.Repository.Implementation
{
    public class FoodRepository : GenericRepository<Food>, IFoodRepository
    {
        public FoodRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
