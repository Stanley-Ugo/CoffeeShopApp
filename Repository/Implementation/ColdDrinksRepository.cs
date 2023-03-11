using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository.Implementation
{
    public class ColdDrinksRepository : GenericRepository<ColdDrink>, IColdDrinksRepository
    {
        public ColdDrinksRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
