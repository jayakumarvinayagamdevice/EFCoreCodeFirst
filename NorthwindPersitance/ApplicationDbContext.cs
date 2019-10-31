using System;
using Microsoft.EntityFrameworkCore;
using PersitanceModel;

namespace NorthwindPersitance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<CustomerDemoGraphic> CustomerDemoGraphics { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }        
        public DbSet<Product> Products { get; set; }
        public DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
        public DbSet<Territories> Territories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CustomerCustomerDemograph> customerCustomerDemographs { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("efcore");

            CategoryConfiguration.Configure(modelBuilder.Entity<Category>());
            ShipperConfiguration.Configure(modelBuilder.Entity<Shipper>());
            RegionConfiguration.Configure(modelBuilder.Entity<Region>());
            SupplierConfiguration.Configure(modelBuilder.Entity<Supplier>());
            EmployeeConfiguration.Configure(modelBuilder.Entity<Employee>());
            CustomerDemographicsConfiguration.Configure(modelBuilder.Entity<CustomerDemoGraphic>());
            CustomerConfiguration.Configure(modelBuilder.Entity<Customer>());
            OrderConfiguration.Configure(modelBuilder.Entity<Order>());
            ProductConfiguration.Configure(modelBuilder.Entity<Product>());
            TerritoryConfiguration.Configure(modelBuilder.Entity<Territories>());
            EmployeeTerritoryConfiguration.Configure(modelBuilder.Entity<EmployeeTerritories>());
            CustomerCustomerDemographConfiguration.Configure(modelBuilder.Entity<CustomerCustomerDemograph>());
            OrderDetailConfiguration.Configure(modelBuilder.Entity<OrderDetail>());

            base.OnModelCreating(modelBuilder);
        }
    }
}