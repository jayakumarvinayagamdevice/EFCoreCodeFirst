using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class RegionConfiguration
    {
        public static void Configure(EntityTypeBuilder<Region> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.RegionId);
        }
    }
}