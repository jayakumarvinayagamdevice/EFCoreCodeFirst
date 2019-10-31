using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class OrderDetailConfiguration
    {
        public static void Configure(EntityTypeBuilder<OrderDetail> entityBuilder)
        {
            entityBuilder.HasKey(x=> new {x.ProductId, x.OrderId});

             entityBuilder.HasOne(x=>x.Product)
                .WithMany(x=>x.OrderDetails)
                .HasForeignKey(x=>x.ProductId)
                .IsRequired(true);

            entityBuilder.HasOne(x=>x.Order)
                .WithMany(x=>x.OrderDetails)
                .HasForeignKey(x=>x.OrderId)
                .IsRequired(true);
        }
    }
}