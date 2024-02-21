using System.ComponentModel.DataAnnotations;
namespace RestaurantAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string Role { get; set; }

        public User()
        {
            Username = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }
    }
}

