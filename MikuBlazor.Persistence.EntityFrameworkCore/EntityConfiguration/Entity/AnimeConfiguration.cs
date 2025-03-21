using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class AnimeConfiguration : EntityConfiguration<Anime>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Anime> builder)
    {
        builder.ToTable(name: "Animes", schema: "App");
    }
}