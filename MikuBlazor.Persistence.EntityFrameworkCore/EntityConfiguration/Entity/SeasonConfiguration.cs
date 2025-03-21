using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

internal sealed class SeasonConfiguration : EntityConfiguration<Season>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Season> builder)
    {
        builder.ToTable(name: "Seasons", schema: "App");
    }
}