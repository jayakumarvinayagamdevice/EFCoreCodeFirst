using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class SupplierConfiguration
    {
        public static void Configure(EntityTypeBuilder<Supplier> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.SupplierId);
        }
    }
}