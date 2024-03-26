using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product
                {
                    Id = Guid.NewGuid(),
                    Active = true,
                    Changed = DateTime.Now,
                    Price = new decimal(2.99),
                    Name = "Eistee",
                    Description = "Pfirsich haltiges Erfrischungsgetränk",
                    Available = true
                }
            ); 
        }
    }
}
