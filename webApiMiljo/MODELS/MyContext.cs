using Microsoft.EntityFrameworkCore;

namespace webApiMiljo.MODELS
{
    public class MyContext : DbContext
    {
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Address>? Address { get; set; }
    
        public MyContext (DbContextOptions options) : base(options) { }//ctor

    }
}
