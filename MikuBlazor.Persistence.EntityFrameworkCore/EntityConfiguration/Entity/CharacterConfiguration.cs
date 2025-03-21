using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class CharacterConfiguration : EntityConfiguration<Character>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Character> builder)
    {
        builder.ToTable(name: "Characters", schema: "App");

        builder.HasOne<Gender>(c => c.Gender)
               .WithMany(g => g.Characters)
               .HasForeignKey(c => c.GenderId);
    }
}