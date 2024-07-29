using JuanBackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanBackendApp.Data
{
    public class JuanDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Banner> Banners { get; set; }

        public JuanDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
