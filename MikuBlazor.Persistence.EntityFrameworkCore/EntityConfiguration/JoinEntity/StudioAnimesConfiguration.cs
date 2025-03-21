using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class StudioAnimesConfiguration : EntityConfiguration<StudioAnimes>
{
    protected override void ConfigureEntity(EntityTypeBuilder<StudioAnimes> builder)
    {
        builder.ToTable(name: "StudioAnimes", schema: "App");
    }
}