using CoffeeShopApp.Models;

namespace CoffeeShopApp.Repository
{
    public interface IUserRepository : IGenericRepository<Users>
    {
        public Users AddUser(Users user);
    }
}
