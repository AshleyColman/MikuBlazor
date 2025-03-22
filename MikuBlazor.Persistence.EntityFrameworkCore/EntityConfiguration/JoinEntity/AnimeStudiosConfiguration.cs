using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class AnimeStudiosConfiguration : EntityConfiguration<AnimeStudios>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeStudios> builder)
    {
        builder.ToTable(name: "AnimeStudios", schema: "App");
    }
}