using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class WebsiteDbContext : DbContext
    {
        public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options) : base(options)
        {
            
        }  

        //public static List<User> Users { get; set; } = new();

        public DbSet<User> Users { get; set; }
    }
}