using Microsoft.EntityFrameworkCore;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Domain.Anime.Enums;
using AnimeStatus = MikuBlazor.Domain.Anime.Entity.AnimeStatus;
using AnimeType = MikuBlazor.Domain.Anime.Entity.AnimeType;
using Genre = MikuBlazor.Domain.Anime.Entity.Genre;
using Season = MikuBlazor.Domain.Anime.Entity.Season;
using ViewerRating = MikuBlazor.Domain.Anime.Entity.ViewerRating;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Context;

public class AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) 
    : DbContext(dbContextOptions)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        SeedDb(modelBuilder);
    }

    private static void SeedDb(ModelBuilder modelBuilder)
    {
        Guid animeTypeId = Domain.Anime.Enums.AnimeType.TV;
        modelBuilder.Entity<AnimeType>().HasData(
        [
            new()
            {
                Id = animeTypeId,
                Name = nameof(Domain.Anime.Enums.AnimeType.TV)
            }
        ]);
        
        Guid animeStatusId = Domain.Anime.Enums.AnimeStatus.Airing;
        modelBuilder.Entity<AnimeStatus>().HasData(
        [
            new()
            {
                Id = animeStatusId,
                Name = nameof(Domain.Anime.Enums.AnimeStatus.Airing)
            }
        ]);
        
        Guid animeProducerId = Domain.Anime.Enums.AnimeProducer.Aniplex;
        modelBuilder.Entity<Producer>().HasData(
        [
            new()
            {
                Id = animeProducerId,
                Name = nameof(Domain.Anime.Enums.AnimeProducer.Aniplex)
            }
        ]);
        
        Guid animeStudioId = Domain.Anime.Enums.AnimeStudio.Madhouse;
        modelBuilder.Entity<Studio>().HasData(
        [
            new()
            {
                Id = animeStudioId,
                Name = nameof(Domain.Anime.Enums.AnimeStudio.Madhouse)
            }
        ]);
        
        Guid seasonId = Domain.Anime.Enums.Season.Fall2025;
        modelBuilder.Entity<Season>().HasData(
        [
            new()
            {
                Id = seasonId,
                Name = nameof(Domain.Anime.Enums.Season.Fall2025)
            }
        ]);
        
        Guid genreId = Domain.Anime.Enums.Genre.Fantasy;
        modelBuilder.Entity<Genre>().HasData(
        [
            new()
            {
                Id = genreId,
                Name = nameof(Domain.Anime.Enums.Genre.Fantasy)
            }
        ]);
        
        Guid viewerRatingId = Domain.Anime.Enums.ViewerRating.PG13;
        modelBuilder.Entity<ViewerRating>().HasData(
        [
            new()
            {
                Id = viewerRatingId,
                Name = nameof(Domain.Anime.Enums.ViewerRating.PG13)
            }
        ]);
        
        modelBuilder.Entity<Anime>().HasData(
        [new()
        {
            Title = "Frieren: Beyond Journey's End",
            JapaneseTitle = "Sousou no Frieren",
            Rating = 10,
            Rank = 1,
            Episodes = 28,
            StatusId = animeStatusId,
            TypeId = animeTypeId,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(28),
            ProducerId = animeProducerId,
            StudioId = animeStudioId,
            SeasonId = seasonId,
            GenreId = genreId,
            ViewerRatingId = viewerRatingId
        }]);
    }
}