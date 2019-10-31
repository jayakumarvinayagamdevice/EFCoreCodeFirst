using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class EmployeeConfiguration
    {
        public static void Configure(EntityTypeBuilder<Employee> endityBuilder)
        {
            endityBuilder.HasKey(x=>x.EmployeeId);
        }
    }
}