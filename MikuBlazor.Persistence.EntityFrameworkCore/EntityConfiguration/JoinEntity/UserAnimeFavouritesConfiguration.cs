using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class UserAnimeFavouritesConfiguration : BaseEntityConfiguration<UserAnimeFavourites>
{
    protected override void ConfigureEntity(EntityTypeBuilder<UserAnimeFavourites> builder)
    {
        builder.ToTable(name: "UserAnimeFavourites", schema: "App");
    }
}