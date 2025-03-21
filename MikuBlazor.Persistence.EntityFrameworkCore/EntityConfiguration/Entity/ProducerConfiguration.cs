using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class ProducerConfiguration : EntityConfiguration<Producer>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Producer> builder)
    {
        builder.ToTable(name: "Producers", schema: "App");
        
        builder.Property(x => x.Name)
               .HasMaxLength(50);
    }
}