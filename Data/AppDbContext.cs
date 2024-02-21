using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;

namespace RestaurantAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Users = Set<User>(); 
            MenuItems = Set<MenuItem>();
        }

        public DbSet<User> Users { get; set; } // Menambahkan properti untuk entitas pengguna
        public DbSet<MenuItem> MenuItems { get; set; }

        // Tambahkan DbSet untuk model lainnya jika diperlukan

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tambahkan konfigurasi lainnya di sini
        }
    }
}
