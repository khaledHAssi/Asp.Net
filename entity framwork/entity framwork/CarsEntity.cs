
using CarsClass;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess;
public class CarsDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source =..\\..\\..\\cars.db");
    }
    public DbSet<Car> Cars { get; set; }

}