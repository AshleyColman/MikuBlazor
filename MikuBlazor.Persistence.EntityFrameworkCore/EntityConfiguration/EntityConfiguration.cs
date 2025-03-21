using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration;

public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity 
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
               .ValueGeneratedNever();

        builder.HasQueryFilter(x => !x.IsDeleted);
        
        ConfigureEntity(builder);
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
}