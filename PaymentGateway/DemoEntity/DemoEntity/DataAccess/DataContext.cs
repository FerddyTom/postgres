using DemoEntity.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoEntity.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<Jutsu> Jutsus { get; set; }
    }
}
