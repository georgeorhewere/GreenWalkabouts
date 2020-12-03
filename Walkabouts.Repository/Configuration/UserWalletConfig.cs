using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Configuration
{
    internal class UserWalletConfig : BaseEntityConfig<UserWallet>
    {
        public override void Configure(EntityTypeBuilder<UserWallet> builder)
        {
            base.Configure(builder);
            builder
               .Property(m => m.Balance)
               .HasColumnType("decimal(10,2)");

            builder
                .HasOne(c => c.UserProfile)
                .WithOne()
                .HasForeignKey<UserWallet>(c => c.UserProfileId);
            

        }
        protected override string EntityName { get => $"{nameof(UserWallet)}s"; }
    }
}