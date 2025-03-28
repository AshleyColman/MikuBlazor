using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class AnimeTagsConfiguration : BaseEntityConfiguration<AnimeTags>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeTags> builder)
    {
        builder.ToTable(name: "AnimeTags", schema: "App");
    }
}