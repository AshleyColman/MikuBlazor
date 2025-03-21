using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class AnimeStatusConfiguration : EntityConfiguration<AnimeStatus>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeStatus> builder)
    {
        builder.ToTable(name: "AnimeStatuses", schema: "App");
        
        builder.Property(x => x.Name)
               .HasMaxLength(50);
    }
}