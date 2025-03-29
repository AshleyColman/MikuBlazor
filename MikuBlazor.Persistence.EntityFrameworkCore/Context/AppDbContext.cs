using Microsoft.EntityFrameworkCore;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Domain.Anime.Enums;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;
using AnimeStatus = MikuBlazor.Domain.Anime.Entity.AnimeStatus;
using AnimeType = MikuBlazor.Domain.Anime.Entity.AnimeType;
using Gender = MikuBlazor.Domain.Anime.Entity.Gender;
using Genre = MikuBlazor.Domain.Anime.Enums.Genre;
using Season = MikuBlazor.Domain.Anime.Entity.Season;
using Tag = MikuBlazor.Domain.Anime.Enums.Tag;
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
        var animeTypeId = SeedAnimeTypes(modelBuilder);
        
        var animeStatusId = SeedAnimeStatuses(modelBuilder);
        
        var animeProducerId = SeedAnimeProducers(modelBuilder);
        
        var animeStudioId = SeedAnimeStudios(modelBuilder);
        
        var seasonId = SeedAnimeSeasons(modelBuilder);
        
        var genreId = SeedGenres(modelBuilder);
        
        var viewerRatingId = SeedViewerRatings(modelBuilder);
        
        var episodeId = SeedEpisodes(modelBuilder);

        SeedGenders(modelBuilder);
        
        var characterId = SeedCharacters(modelBuilder);
        
        var animeId = SeedAnimes(modelBuilder, animeStatusId, animeTypeId, animeProducerId, animeStudioId, seasonId, genreId, viewerRatingId);
        
        SeedTags(modelBuilder);

        SeedAnimeCharacters(modelBuilder, animeId, characterId);
        
        SeedAnimeGenres(modelBuilder, animeId);
        
        SeedAnimeProducers(modelBuilder, animeId);
        
        SeedAnimeStudios(modelBuilder, animeId);
        
        SeedAnimeTags(modelBuilder, animeId);
        
        SeedAnimeEpisodes(modelBuilder, animeId, episodeId);
    }

    private static void SeedAnimeEpisodes(ModelBuilder modelBuilder, Guid animeId, Guid episodeId)
    {
        modelBuilder.Entity<AnimeEpisodes>().HasData(
        [
            new AnimeEpisodes
            {
                Id = Guid.NewGuid(),
                AnimeId = animeId,
                EpisodeId = episodeId
            } 
        ]);
    }

    private static void SeedAnimeTags(ModelBuilder modelBuilder, Guid animeId)
    {
        modelBuilder.Entity<AnimeTags>().HasData(
        [
            new AnimeTags
            {
                Id = Guid.NewGuid(),
                AnimeId = animeId,
                TagId = Tag.Fantasy
            } 
        ]);
    }

    private static void SeedAnimeStudios(ModelBuilder modelBuilder, Guid animeId)
    {
        modelBuilder.Entity<AnimeStudios>().HasData(
        [
            new AnimeStudios
            {
                Id = Guid.NewGuid(),
                AnimeId = animeId,
                StudioId = AnimeStudio.Madhouse
            } 
        ]);
    }

    private static void SeedAnimeProducers(ModelBuilder modelBuilder, Guid animeId)
    {
        modelBuilder.Entity<AnimeProducers>().HasData(
        [
            new AnimeProducers
            {
                Id = Guid.NewGuid(),
                AnimeId = animeId,
                ProducerId = AnimeProducer.Aniplex
            } 
        ]);
    }

    private static void SeedAnimeCharacters(ModelBuilder modelBuilder, Guid animeId, Guid characterId)
    {
        modelBuilder.Entity<AnimeCharacters>().HasData(
        [
            new AnimeCharacters
            {
                Id = Guid.NewGuid(),
                AnimeId = animeId,
                CharacterId = characterId
            } 
        ]);
    }
    
    private static void SeedAnimeGenres(ModelBuilder modelBuilder, Guid animeId)
    {
        modelBuilder.Entity<AnimeGenres>().HasData(
        [
            new AnimeGenres()
            {
                Id = Guid.NewGuid(),
                AnimeId = animeId,
                GenreId = Genre.Fantasy
            } 
        ]);
    }

    private static void SeedGenders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gender>().HasData(
        [
            new Gender
            {
                Id = Domain.Anime.Enums.Gender.Female,
                Name = "Female"
            },
            new Gender
            {
                Id = Domain.Anime.Enums.Gender.Male,
                Name = "Male"
            },
            new Gender
            {
                Id = Domain.Anime.Enums.Gender.Other,
                Name = "Other"
            }
        ]);
    }

    private static void SeedTags(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Anime.Entity.Tag>().HasData(
        [
            new()
            {
                Id = Tag.Fantasy,
                Name = "Fantasy"
            }
        ]);
    }

    private static Guid SeedAnimes(ModelBuilder modelBuilder, Guid animeStatusId, Guid animeTypeId, Guid animeProducerId,
        Guid animeStudioId, Guid seasonId, Guid genreId, Guid viewerRatingId)
    {
        Guid animeId = Guid.Parse("4AFF0276-F322-42EC-B75B-F64851ECFC5E"); // TODO: Remove: Hardcode for testing
        
        modelBuilder.Entity<Anime>().HasData(
        [new()
            {
                Id = animeId,
                Title = "Frieren: Beyond Journey's End",
                JapaneseTitle = "Sousou no Frieren",
                Rating = 10,
                Rank = 1,
                StatusId = animeStatusId,
                TypeId = animeTypeId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(28),
                SeasonId = seasonId,
                ViewerRatingId = viewerRatingId
            }]);

        return animeId;
    }

    private static Guid SeedCharacters(ModelBuilder modelBuilder)
    {
        Guid characterId = Guid.NewGuid();
        modelBuilder.Entity<Character>().HasData(
        [
            new Character
            {
                Id = characterId,
                FirstName = "Frieren",
                LastName = string.Empty,
                Age = 1000,
                NickName = "Frieren the Slayer",
                JapaneseName = "フリーレン",
                GenderId = Domain.Anime.Enums.Gender.Female,
                Description = "Frieren is a powerful warrior who has lived for over 1000 years. She is known as the Slayer and is feared by many.",
                ImageUri = "https://cdn.myanimelist.net/images/characters/16/366547.jpg"
            }
        ]);

        return characterId;
    }

    private static Guid SeedEpisodes(ModelBuilder modelBuilder)
    {
        Guid episodeId = Guid.NewGuid();
        modelBuilder.Entity<Episode>().HasData(
        [
            new Episode
            {
                Id = episodeId,
                Title = "Episode 1",
                Description = "Episode 1description",
                Number = 1
            }
        ]);

        return episodeId;
    }

    private static Guid SeedViewerRatings(ModelBuilder modelBuilder)
    {
        Guid viewerRatingId = Domain.Anime.Enums.ViewerRating.PG13;
        modelBuilder.Entity<ViewerRating>().HasData(
        [
            new()
            {
                Id = viewerRatingId,
                Name = nameof(Domain.Anime.Enums.ViewerRating.PG13)
            }
        ]);
        return viewerRatingId;
    }

    private static Guid SeedGenres(ModelBuilder modelBuilder)
    {
        Guid genreId = Domain.Anime.Enums.Genre.Fantasy;
        modelBuilder.Entity<Domain.Anime.Entity.Genre>().HasData(
        [
            new()
            {
                Id = genreId,
                Name = nameof(Domain.Anime.Enums.Genre.Fantasy)
            }
        ]);
        return genreId;
    }

    private static Guid SeedAnimeSeasons(ModelBuilder modelBuilder)
    {
        Guid seasonId = Domain.Anime.Enums.Season.Fall2025;
        modelBuilder.Entity<Season>().HasData(
        [
            new()
            {
                Id = seasonId,
                Name = nameof(Domain.Anime.Enums.Season.Fall2025)
            }
        ]);
        return seasonId;
    }

    private static Guid SeedAnimeStudios(ModelBuilder modelBuilder)
    {
        Guid animeStudioId = Domain.Anime.Enums.AnimeStudio.Madhouse;
        modelBuilder.Entity<Studio>().HasData(
        [
            new()
            {
                Id = animeStudioId,
                Name = nameof(Domain.Anime.Enums.AnimeStudio.Madhouse)
            }
        ]);
        return animeStudioId;
    }

    private static Guid SeedAnimeProducers(ModelBuilder modelBuilder)
    {
        Guid animeProducerId = Domain.Anime.Enums.AnimeProducer.Aniplex;
        modelBuilder.Entity<Producer>().HasData(
        [
            new()
            {
                Id = animeProducerId,
                Name = nameof(Domain.Anime.Enums.AnimeProducer.Aniplex)
            }
        ]);
        return animeProducerId;
    }

    private static Guid SeedAnimeStatuses(ModelBuilder modelBuilder)
    {
        Guid animeStatusId = Domain.Anime.Enums.AnimeStatus.Airing;
        modelBuilder.Entity<AnimeStatus>().HasData(
        [
            new()
            {
                Id = animeStatusId,
                Name = nameof(Domain.Anime.Enums.AnimeStatus.Airing)
            }
        ]);
        return animeStatusId;
    }

    private static Guid SeedAnimeTypes(ModelBuilder modelBuilder)
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
        return animeTypeId;
    }
}