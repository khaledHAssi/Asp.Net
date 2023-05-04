using DatabaseAccess.Entity ; 
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess;
public class CarsDbContext : DbContext {

    protected override void OnConfiguring(DbContextOptions optionsBuilder){
        optionsBuilder.UseSqlite("..\\..\\..\\cars.db");
    }
    
    public DbSet<Car>
}