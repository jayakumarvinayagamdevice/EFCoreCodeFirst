using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class TerritoryConfiguration
    {
        public static void Configure(EntityTypeBuilder<Territories> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.TerritoryId);
            entityBuilder.HasOne(x=>x.Region)
                .WithMany(x=>x.Territories)
                .HasForeignKey(x=>x.RegionId);
        }
    }
}