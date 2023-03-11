using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Models
{
    public class Order_Item
    {
        [Key]
        public int Id { get; set; }

        // Foreign key   
        [Display(Name = "Order")]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Orders { get; set; }

        public string ItemType { get; set; }

        // Foreign key   
        [Display(Name = "Hot Drink")]
        public int HotDrinkId { get; set; }

        [ForeignKey("HotDrinkId")]
        public virtual HotDrink HotDrinks { get; set; }

        // Foreign key   
        [Display(Name = "Cold Drink")]
        public int ColdDrinkId { get; set; }

        [ForeignKey("ColdDrinkId")]
        public virtual ColdDrink ColdDrinks { get; set; }

        // Foreign key   
        [Display(Name = "Food")]
        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public virtual Food Foods { get; set; }

        public int Quantity { get; set; }
    }
}
