using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class ProducerAnimesConfiguration : EntityConfiguration<ProducerAnimes>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ProducerAnimes> builder)
    {
        builder.ToTable(name: "ProducerAnimes", schema: "App");
    }
}