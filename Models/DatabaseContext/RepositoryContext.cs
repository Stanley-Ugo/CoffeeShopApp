using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Models.DatabaseContext
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Item> Order_Items { get; set; }
        public DbSet<HotDrink> HotDrinks { get; set; }
        public DbSet<ColdDrink> ColdDrinks { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
