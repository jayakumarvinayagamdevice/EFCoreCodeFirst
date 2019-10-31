using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class ShipperConfiguration
    {
        public static void Configure(EntityTypeBuilder<Shipper> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.ShipperId);
            entityBuilder.Property(x=>x.CompanyName).HasMaxLength(40);
            entityBuilder.Property(x=>x.Phone).HasMaxLength(24);
        }
    }
}