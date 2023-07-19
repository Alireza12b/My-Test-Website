using Domain.Entities;

namespace Persistance
{
    public static class DataBase
    {
        public static List<User> Users { get; set; } = new();
    }
}