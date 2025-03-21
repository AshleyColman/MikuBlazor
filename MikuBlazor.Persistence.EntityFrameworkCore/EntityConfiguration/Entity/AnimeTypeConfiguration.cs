using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class AnimeTypeConfiguration : EntityConfiguration<AnimeType>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeType> builder)
    {
        builder.ToTable(name: "AnimeTypes", schema: "App");
    }
}