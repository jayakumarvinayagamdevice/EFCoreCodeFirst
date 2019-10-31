using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersitanceModel
{
    public static class CategoryConfiguration
    {
        public static void Configure(EntityTypeBuilder<Category> entityBuilder)
        {
            entityBuilder.HasKey(x=>x.CategoryId);
        }
    }
}