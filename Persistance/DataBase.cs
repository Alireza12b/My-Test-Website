using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions<DataBase> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ALIREZA;Initial Catalog=MyWebsite;Integrated Security=True");
        }
        

        //public static List<User> Users { get; set; } = new();

        public DbSet<User> Users { get; set; }
    }
}