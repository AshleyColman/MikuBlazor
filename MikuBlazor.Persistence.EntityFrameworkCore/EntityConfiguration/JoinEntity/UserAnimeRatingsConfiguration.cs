using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class UserAnimeRatingsConfiguration : BaseEntityConfiguration<UserAnimeRatings>
{
    protected override void ConfigureEntity(EntityTypeBuilder<UserAnimeRatings> builder)
    {
        builder.ToTable(name: "UserAnimeRatings", schema: "App");
    }
}