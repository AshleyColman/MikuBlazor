using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

internal sealed class SeasonConfiguration : BaseEntityConfiguration<Season>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Season> builder)
    {
        builder.ToTable(name: "Seasons", schema: "App");
        
        builder.Property(x => x.Name)
            .HasMaxLength(25);
    }
}