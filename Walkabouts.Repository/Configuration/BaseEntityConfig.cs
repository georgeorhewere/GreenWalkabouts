using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Configuration
{
    public class BaseEntityConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder
           .HasKey(a => a.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .ToTable(EntityName);
        }
        protected virtual string EntityName { get => $"{nameof(TEntity)}s"; }
    }
}