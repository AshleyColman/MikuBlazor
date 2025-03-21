using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Domain.Anime.Entity.Entity 
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