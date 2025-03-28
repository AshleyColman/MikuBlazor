using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Domain.Anime.JoinEntity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class AnimeConfiguration : BaseEntityConfiguration<Anime>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Anime> builder)
    { 
        builder.ToTable(name: "Animes", schema: "App");
        
        builder.Property(a => a.Title)
               .HasMaxLength(250);
    
        builder.Property(a => a.JapaneseTitle)
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
               .WithMany(p => p.Animes)
               .UsingEntity<AnimeProducers>(
                      join => join
                             .HasOne(ap => ap.Producer)
                             .WithMany()
                             .HasForeignKey(ap => ap.ProducerId),
                      join => join
                             .HasOne(ap => ap.Anime)
                             .WithMany()
                             .HasForeignKey(ap => ap.AnimeId));
        
        builder.HasMany(a => a.Studios)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeStudios>(
                      join => join
                             .HasOne(x => x.Studio)
                             .WithMany()
                             .HasForeignKey(x => x.StudioId),
                      join => join
                             .HasOne(x => x.Anime)
                             .WithMany()
                             .HasForeignKey(x => x.AnimeId));
        
        builder.HasMany(a => a.Genres)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeGenres>(
                      join => join
                             .HasOne(ag => ag.Genre)
                             .WithMany()
                             .HasForeignKey(ag => ag.GenreId),
                      join => join
                             .HasOne(ag => ag.Anime)
                             .WithMany()
                             .HasForeignKey(ag => ag.AnimeId));
        
        builder.HasMany(a => a.Tags)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeTags>(
                      join => join
                             .HasOne(at => at.Tag)
                             .WithMany()
                             .HasForeignKey(at => at.TagId),
                      join => join
                             .HasOne(at => at.Anime)
                             .WithMany()
                             .HasForeignKey(at => at.AnimeId));
        
        builder.HasMany(a => a.Episodes)
               .WithMany(c => c.Animes)
               .UsingEntity<AnimeEpisodes>(
                      join => join
                             .HasOne(ae => ae.Episode)
                             .WithMany()
                             .HasForeignKey(ae => ae.EpisodeId),
                      join => join
                             .HasOne(ae => ae.Anime)
                             .WithMany()
                             .HasForeignKey(ae => ae.AnimeId));
    }
}