using Microsoft.EntityFrameworkCore;

namespace MiniProject002.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> MiniProject002_Categories { get; set; }
        public DbSet<Product> MiniProject002_Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-2JK6GIJ7\\SQLEXPRESS;Database=MiniProjects;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
