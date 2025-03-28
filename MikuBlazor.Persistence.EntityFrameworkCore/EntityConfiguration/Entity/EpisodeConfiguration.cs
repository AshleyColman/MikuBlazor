using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public class EpisodeConfiguration : BaseEntityConfiguration<Episode>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Episode> builder)
    {
        builder.ToTable(name: "Episodes", schema: "App");
    }
}