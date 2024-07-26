using JuanBackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanBackendApp.Data
{
    public class JuanDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public JuanDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
