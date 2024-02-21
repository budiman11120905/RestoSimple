namespace RestaurantAPI.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserModel()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }

}
