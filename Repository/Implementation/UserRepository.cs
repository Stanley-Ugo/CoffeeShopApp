using CoffeeShopApp.Models;
using CoffeeShopApp.Models.DatabaseContext;

namespace CoffeeShopApp.Repository.Implementation
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public UserRepository(RepositoryContext context) : base(context)
        {
            _repositoryContext = context;
        }

        public Users AddUser(Users user)
        {
            var insertUser = _repositoryContext.Add(user);

            return insertUser.Entity;
        }
    }
}
