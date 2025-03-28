using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class AnimeTypeConfiguration : BaseEntityConfiguration<AnimeType>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeType> builder)
    {
        builder.ToTable(name: "AnimeTypes", schema: "App");
            
        builder.Property(x => x.Name)
            .HasMaxLength(50);
    }
}