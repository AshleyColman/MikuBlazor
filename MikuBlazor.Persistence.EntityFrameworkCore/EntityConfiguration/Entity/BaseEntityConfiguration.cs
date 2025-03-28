using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public abstract class BaseEntityConfiguration<T> 
    : IEntityTypeConfiguration<T> where T : Domain.Anime.Entity.Entity
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever();
        
        ConfigureEntity(builder);
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
}