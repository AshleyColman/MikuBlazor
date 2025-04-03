using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class UserConfiguration : BaseEntityConfiguration<User>
{
    protected override void ConfigureEntity(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(name: "Users", schema: "App");
        
        builder.Property(x => x.Username)
            .HasMaxLength(25);

        builder.HasOne(u => u.Gender)
            .WithMany(g => g.Users)
            .HasForeignKey(u => u.GenderId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        
        builder.HasMany(u => u.AnimeRatings)
            .WithOne(uar => uar.User)
            .HasForeignKey(uar => uar.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        
        builder.HasMany(u => u.AnimeFavourites)
            .WithOne(uaf => uaf.User)
            .HasForeignKey(uaf => uaf.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        
        builder.HasMany(u => u.CharacterFavourites)
            .WithOne(ucf => ucf.User)
            .HasForeignKey(ucf => ucf.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}