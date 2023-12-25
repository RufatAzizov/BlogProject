using BlogProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BlogProject.Context
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-R4EGFJU\\SQLEXPRESS;Database=BlogProjectDb;Trusted_Connection=True;");
        }

        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }

    }
}
