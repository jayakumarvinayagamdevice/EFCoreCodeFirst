using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class EmployeeTerritoryConfiguration
    {
        public static void Configure(EntityTypeBuilder<EmployeeTerritories> entityBuilder)
        {
            entityBuilder.HasKey(x => new { x.EmployeeId, x.TerritoryId });
            entityBuilder.HasOne(x => x.Employee)
            .WithMany(x => x.EmployeeTerritories)
            .HasForeignKey(x => x.EmployeeId);
            entityBuilder.HasOne(x => x.Territories)
            .WithMany(x => x.EmployeeTerritories)
            .HasForeignKey(x => x.TerritoryId);
        }
    }
}