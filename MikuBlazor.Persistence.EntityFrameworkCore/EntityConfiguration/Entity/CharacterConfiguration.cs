using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class CharacterConfiguration : BaseEntityConfiguration<Character>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Character> builder)
    {
        builder.ToTable(name: "Characters", schema: "App");

        builder.Property(x => x.FirstName)
            .HasMaxLength(50);
        
        builder.Property(x => x.LastName)
            .HasMaxLength(50);
        
        builder.Property(x => x.JapaneseName)
            .HasMaxLength(250);
        
        builder.Property(x => x.NickName)
            .HasMaxLength(50);
        
        builder.Property(x => x.Description)
            .HasMaxLength(2500);
        
        builder.Property(x => x.ImageUri)
            .HasMaxLength(4000);
        
        builder.HasOne<Gender>(c => c.Gender)
            .WithMany(g => g.Characters)
            .HasForeignKey(c => c.GenderId);
    }
}