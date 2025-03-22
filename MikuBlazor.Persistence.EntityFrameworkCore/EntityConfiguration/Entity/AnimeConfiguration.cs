using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Domain.Anime.JoinEntity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class AnimeConfiguration : EntityConfiguration<Anime>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Anime> builder)
    {
        builder.ToTable(name: "Animes", schema: "App");

        builder.Property(x => x.Title)
               .HasMaxLength(250);
    
        builder.Property(x => x.JapaneseTitle)
               .HasMaxLength(250);
               
        builder.HasOne<AnimeStatus>(a => a.Status)
               .WithMany(s => s.Animes)
               .HasForeignKey(a => a.StatusId);

        builder.HasOne<AnimeType>(a => a.Type)
               .WithMany(t => t.Animes)
               .HasForeignKey(a => a.TypeId);
        
        builder.HasOne<Season>(a => a.Season)
               .WithMany(s => s.Animes)
               .HasForeignKey(a => a.SeasonId);
        
        builder.HasOne<ViewerRating>(a => a.ViewerRating)
               .WithMany(vr => vr.Animes)
               .HasForeignKey(a => a.ViewerRatingId);

        builder.HasMany(a => a.Characters)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeCharacters>(
                      join => join
                             .HasOne(ac => ac.Character)
                             .WithMany()
                             .HasForeignKey(ac => ac.CharacterId),
                      join => join
                             .HasOne(ac => ac.Anime)
                             .WithMany()
                             .HasForeignKey(ac => ac.AnimeId));
        
        builder.HasMany(a => a.Producers)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeProducers>(
                      join => join
                             .HasOne(ac => ac.Producer)
                             .WithMany()
                             .HasForeignKey(ac => ac.ProducerId),
                      join => join
                             .HasOne(ac => ac.Anime)
                             .WithMany()
                             .HasForeignKey(ac => ac.AnimeId));
        
        builder.HasMany(a => a.Studios)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeStudios>(
                      join => join
                             .HasOne(ac => ac.Studio)
                             .WithMany()
                             .HasForeignKey(ac => ac.StudioId),
                      join => join
                             .HasOne(ac => ac.Anime)
                             .WithMany()
                             .HasForeignKey(ac => ac.AnimeId));
        
        builder.HasMany(a => a.Genres)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeGenres>(
                      join => join
                             .HasOne(ac => ac.Genre)
                             .WithMany()
                             .HasForeignKey(ac => ac.GenreId),
                      join => join
                             .HasOne(ac => ac.Anime)
                             .WithMany()
                             .HasForeignKey(ac => ac.AnimeId));
        
        builder.HasMany(a => a.Tags)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeTags>(
                      join => join
                             .HasOne(ac => ac.Tag)
                             .WithMany()
                             .HasForeignKey(ac => ac.TagId),
                      join => join
                             .HasOne(ac => ac.Anime)
                             .WithMany()
                             .HasForeignKey(ac => ac.AnimeId));
    }
}