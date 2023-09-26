using FSMotors.Models;
using Microsoft.EntityFrameworkCore;


namespace FSMotors.Models
{
    public class FSDbContext : DbContext
    {
        public FSDbContext(DbContextOptions<FSDbContext> options) : base(options)
        { }

        public DbSet<User> users { get; set; }
    }
}
