using FSMotors.Models;
using Microsoft.EntityFrameworkCore;


namespace BankTransactions.Models
{
    public class DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {}
            
        public DbSet<User> users { get; set; }
    }
}
