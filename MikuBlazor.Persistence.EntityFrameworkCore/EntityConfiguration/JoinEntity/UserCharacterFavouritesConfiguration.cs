using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class UserCharacterFavouritesConfiguration : EntityConfiguration<UserCharacterFavourites>
{
    protected override void ConfigureEntity(EntityTypeBuilder<UserCharacterFavourites> builder)
    {
        builder.ToTable(name: "UserCharacterFavourites", schema: "App");
    }
}