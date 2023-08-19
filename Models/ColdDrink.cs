using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApp.Models
{
    public class ColdDrink
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, ErrorMessage = "Description can't be longer than 100 characters")]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
