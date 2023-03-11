using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository.Implementation
{
    public class FoodRepository : GenericRepository<Food>, IFoodRepository
    {
        public FoodRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
