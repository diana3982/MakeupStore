using System;
using MakeupStore.BLL;
using Microsoft.EntityFrameworkCore;

namespace MakeupStore.DataAccess
{
    public class MakeupStoreDbContext : DbContext
    {
        public MakeupStoreDbContext()
        {   
        
        }

        public MakeupStoreDbContext(DbContextOptions<MakeupStoreDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
