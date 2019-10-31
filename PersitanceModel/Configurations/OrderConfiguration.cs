using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class OrderConfiguration
    {
        public static void Configure(EntityTypeBuilder<Order>entityBuilder)
        {
            entityBuilder.HasKey(x=>x.OrderId);
            
            entityBuilder.HasOne(x=>x.Customer).WithMany(x=>x.Orders)
            .HasForeignKey(x=>x.CustomerId).IsRequired(false); 
 
            entityBuilder.HasOne(x=>x.Employee).WithMany(x=>x.Orders)
            .HasForeignKey(x=>x.EmployeeId).IsRequired(false);
 
            entityBuilder.HasOne(x=>x.Shipper).WithMany(x=>x.Orders)
                .HasForeignKey(x=>x.ShipperId).IsRequired(false);        
        }
    }
}