using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Walkabouts.Data.Domain;
using Walkabouts.Repository.Configuration;

namespace Walkabouts.Repository.Context
{
    public class WalkaboutsDbContext : IdentityDbContext<AppUser, AppRole , long>
    {

        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<UserWallet> UserWallets { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public WalkaboutsDbContext(DbContextOptions<WalkaboutsDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .ApplyConfiguration(new UserProfileConfig());
            modelBuilder
                .ApplyConfiguration(new UserWalletConfig());
            modelBuilder
                .ApplyConfiguration(new ShoppingCartConfig());
            modelBuilder
             .ApplyConfiguration(new ProductConfig());

        }

        public async Task<int> CommitAsync()
        {
            return await this.SaveChangesAsync();
        }
    }
}
