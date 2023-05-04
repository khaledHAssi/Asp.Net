using Microsoft.EntityFrameworkCore;

namespace PlaylistCrud.Models
{
    public class ApplicationDbContext : DbContext //will inherit properites from dbContext class 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
                    
        }
    }
}
