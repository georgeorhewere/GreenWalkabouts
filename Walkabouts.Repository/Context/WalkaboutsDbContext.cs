using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Context
{
    public class WalkaboutsDbContext : IdentityDbContext<AppUser, AppRole , long>
    {
        public WalkaboutsDbContext(DbContextOptions<WalkaboutsDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //new ProductMap(modelBuilder.Entity<Product>());
            //new ProductDetailMap(modelBuilder.Entity<ProductDetails>());
        }

        public async Task<int> CommitAsync()
        {
            return await this.SaveChangesAsync();
        }
    }
}
