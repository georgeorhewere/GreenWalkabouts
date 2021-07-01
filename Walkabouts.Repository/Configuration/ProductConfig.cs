using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Configuration
{
    internal class ProductConfig : BaseEntityConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            
            builder
               .Property(m => m.UnitPrice)
               .HasColumnType("decimal(18,2)")
               .IsRequired();
            builder
               .Property(m => m.ProductName)
               .IsRequired();                
            builder
               .Property(m => m.Description);
            builder
               .Property(m => m.StockLevel)
               .IsRequired();          

          
            builder.HasData(
                    new Product
                    {
                        Id=1,
                        ProductName = "Samsung 50 inch",
                        Description = "",
                        UnitPrice = (decimal)3400.00,
                        StockLevel = 15,
                        CreatedOn= DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "SkyRun Fridge",
                        Description = "energy saving product",
                        UnitPrice = (decimal)4000.00,
                        StockLevel = 11,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "IPhone 6s",
                        Description = "",
                        UnitPrice = (decimal)400.00,
                        StockLevel = 5,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "OX Fan 10 inch",
                        Description = "",
                        UnitPrice = (decimal)300.00,
                        StockLevel = 15,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    }

                    );

        }

        protected override string EntityName { get => $"{nameof(Product)}s"; }
    }
}