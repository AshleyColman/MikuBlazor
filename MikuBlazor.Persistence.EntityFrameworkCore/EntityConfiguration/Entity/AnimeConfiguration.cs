using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

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
    }
}