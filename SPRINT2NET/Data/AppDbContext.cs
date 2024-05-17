using Microsoft.EntityFrameworkCore;
using SPRINT2NET.Models;


namespace SPRINT2NET.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }


    }
}
