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

        builder.HasOne<AnimeStatus>(a => a.Status)
               .WithMany(s => s.Animes)
               .HasForeignKey(a => a.StatusId);

        builder.HasOne<AnimeType>(a => a.Type)
               .WithMany(t => t.Animes)
               .HasForeignKey(a => a.TypeId);

        builder.HasMany<Producer>(a => a.Producers)
               .WithMany(p => p.Animes)
               .UsingEntity<ProducerAnimes>();
        
        builder.HasMany<Studio>(a => a.Studios)
               .WithMany(s => s.Animes)
               .UsingEntity<StudioAnimes>();
        
        builder.HasOne<Season>(a => a.Season)
               .WithMany(s => s.Animes)
               .HasForeignKey(a => a.SeasonId);
        
        builder.HasMany<Genre>(a => a.Genres)
               .WithMany(s => s.Animes)
               .UsingEntity<AnimeGenres>();
        
        builder.HasOne<ViewerRating>(a => a.ViewerRating)
               .WithMany(vr => vr.Animes)
               .HasForeignKey(a => a.ViewerRatingId);
    }
}