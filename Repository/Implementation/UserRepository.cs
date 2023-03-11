using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Repository.Implementation
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
