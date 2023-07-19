using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions<DataBase> options) : base(options)
        {
            
        }
        //public static List<User> Users { get; set; } = new();

        public DbSet<User> Users { get; set; }
    }
}