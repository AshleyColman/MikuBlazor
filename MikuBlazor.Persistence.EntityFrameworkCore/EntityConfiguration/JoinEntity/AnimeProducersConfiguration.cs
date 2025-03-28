using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class AnimeProducersConfiguration : BaseEntityConfiguration<AnimeProducers>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeProducers> builder)
    {
        builder.ToTable(name: "AnimeProducers", schema: "App");
    }
}