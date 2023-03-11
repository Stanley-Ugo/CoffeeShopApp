using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository.Implementation
{
    public class HotDrinksRepository : GenericRepository<HotDrink>, IHotDrinksRepository
    {
        public HotDrinksRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
