using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class ProductConfiguration
    {
        public static void Configure(EntityTypeBuilder<Product> entityBuilder){
            entityBuilder.HasKey(x=>x.ProductId);
            
            entityBuilder.HasOne(x=>x.Category)
                .WithMany(x=>x.Products)
                .HasForeignKey(x=>x.CategoryId)
                .IsRequired(false);
                
            entityBuilder.HasOne(x=>x.Supplier)
                .WithMany(x=>x.Products)
                .HasForeignKey(x=>x.SupplierId)
                .IsRequired(false);
        }
    }
}