using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Configuration
{
    internal class ProductReviewConfig : BaseEntityConfig<ProductReview> { 
   
        public override void Configure(EntityTypeBuilder<ProductReview> builder)
        {
            base.Configure(builder);

            builder
               .Property(m => m.ReviewBy);
            builder
               .Property(m => m.NumOfStars)
               .IsRequired();
            builder
               .Property(m => m.Comment);
            builder
               .Property(m => m.ProductId)
               .IsRequired();
        
            builder.HasOne(m => m.Product)
                .WithOne()
                .HasForeignKey<ProductReview>(m => m.ProductId);           

        }

        protected override string EntityName { get => $"{nameof(ProductReview)}s"; }
    }
}
