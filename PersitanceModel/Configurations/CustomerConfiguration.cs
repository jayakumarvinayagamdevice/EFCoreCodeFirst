using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class CustomerConfiguration
    {
        public static void Configure(EntityTypeBuilder<Customer> entityBuilder)
        {
            entityBuilder.HasKey(x=> x.CustomerId);
        }
    }
}