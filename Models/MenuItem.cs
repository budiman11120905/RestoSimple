namespace RestaurantAPI.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string NamaItem { get; set; }
        public string Status { get; set; }

        public MenuItem()
        {
            NamaItem = string.Empty;
            Status = string.Empty;
        }
    }
}
