using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShopApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        // Foreign key   
        [Display(Name = "User")]
        public virtual int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }
        public int OderId { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
