using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class CustomerCustomerDemographConfiguration
    {
        public static void Configure(EntityTypeBuilder<CustomerCustomerDemograph> entityBuilder)
        {
            entityBuilder.HasKey(x => new { x.CustomerId, x.CustomerTypeId });
            entityBuilder.HasOne(x => x.Customer)
                .WithMany(x => x.CustomerCustomerDemographs)
                .HasForeignKey(x => x.CustomerId);

            entityBuilder.HasOne(x => x.CustomerDemoGraphic)
                .WithMany(x => x.CustomerCustomerDemographs)
                .HasForeignKey(x => x.CustomerTypeId);
        }
    }
}
 