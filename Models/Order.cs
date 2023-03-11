using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
        public decimal TotalCost { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
