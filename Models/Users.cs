using System.ComponentModel.DataAnnotations;

namespace CoffeeShopApp.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(11, ErrorMessage = "Phone cannot be longer than 11 characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
        public string Address { get; set; }
    }
}
