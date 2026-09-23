using DemoMVCHung.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMVCHung.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        // public DbSet<DemoMVCHung.Models.Product> Product { get; set; } = default!;
    }
}