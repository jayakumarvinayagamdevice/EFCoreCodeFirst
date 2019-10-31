using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class CustomerDemographicsConfiguration
    {
        public static void Configure(EntityTypeBuilder<CustomerDemoGraphic> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.CustomerTypeId);
        }
    }

}