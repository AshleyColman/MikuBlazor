using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class AnimeGenresConfiguration : EntityConfiguration<AnimeGenres>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeGenres> builder)
    {
        builder.ToTable(name: "AnimeGenres", schema: "App");
    }
}