using Microsoft.EntityFrameworkCore;

namespace webApiMiljo.MODELS
{
    public class MyContext : DbContext
    {
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Address>? Address { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

    
        public MyContext (DbContextOptions options) : base(options) { }//ctor

    }
}
