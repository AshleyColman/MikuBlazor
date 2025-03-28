using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class GenreConfiguration : BaseEntityConfiguration<Genre>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Genre> builder)
    {
        builder.ToTable(name: "Genres", schema: "App");
    }
}