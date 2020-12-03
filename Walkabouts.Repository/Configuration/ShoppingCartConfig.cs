using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Configuration
{
    internal class ShoppingCartConfig : BaseEntityConfig<ShoppingCart>
    {
        public override void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            base.Configure(builder);

            builder
               .Property(m => m.CartTotal)
               .HasColumnType("decimal(10,2)");

            builder
                .HasOne(c => c.UserProfile)
                .WithOne()
                .HasForeignKey<ShoppingCart>(c => c.UserProfileId);

            builder
                .HasMany(o => o.ShoppingCartItems)
                .WithOne()
                .HasForeignKey(m => m.ShoppingCartId);



        }

        protected override string EntityName { get => $"{nameof(ShoppingCart)}s"; }

    }
}