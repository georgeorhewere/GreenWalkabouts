﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Configuration
{
    internal class UserProfileConfig : BaseEntityConfig<UserProfile>
    {
        public override void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            base.Configure(builder);

            builder
                .Property(b => b.UserId)
                .IsRequired();

            builder
                .HasOne(m => m.AppUser) 
                .WithOne(m =>m.UserProfile)
                .HasForeignKey<UserProfile>(m=>m.UserId);
            
            builder
               .HasOne(m => m.ShoppingCart)
               .WithOne(m => m.UserProfile)
               .HasForeignKey<UserProfile>(m => m.ShoppingCartId);
            builder
               .HasOne(m => m.UserWallet)
               .WithOne(m => m.UserProfile)
               .HasForeignKey<UserProfile>(m => m.UserWalletId);
        }

        protected override string EntityName { get => $"{nameof(UserProfile)}s"; }

    }
}
