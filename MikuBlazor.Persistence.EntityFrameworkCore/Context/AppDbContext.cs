using Microsoft.EntityFrameworkCore;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Domain.Anime.Enums;
using MikuBlazor.Domain.Anime.JoinEntity;
using AnimeStatus = MikuBlazor.Domain.Anime.Entity.AnimeStatus;
using AnimeType = MikuBlazor.Domain.Anime.Entity.AnimeType;
using Gender = MikuBlazor.Domain.Anime.Enums.Gender;
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
        
        var userId = SeedUsers(modelBuilder);
        
        SeedUserAnimeFavourites(modelBuilder, animeId, userId);

        SeedUserCharacterFavourites(modelBuilder, characterId, userId);

        SeedUserAnimeRatings(modelBuilder, animeId, userId);
    }

    private static void SeedUserAnimeRatings(ModelBuilder modelBuilder, Guid animeId, Guid userId)
    {
        modelBuilder.Entity<UserAnimeRatings>().HasData(
        [
            new UserAnimeRatings
            {
                Id = Guid.Parse("1CC0046D-3EC6-481D-9A6D-4EC9CF0A3BC9"),
                AnimeId = animeId,
                Rating = 100,
                UserId = userId
            } 
        ]);
    }
    
    private static void SeedUserCharacterFavourites(ModelBuilder modelBuilder, Guid characterId, Guid userId)
    {
        modelBuilder.Entity<UserCharacterFavourites>().HasData(
        [
            new UserCharacterFavourites
            {
                Id = Guid.Parse("9AB33B77-5795-4649-BAC3-67C3328A5C1E"),
                CharacterId = characterId,
                UserId = userId
            } 
        ]);
    }
    
    private static void SeedUserAnimeFavourites(ModelBuilder modelBuilder, Guid animeId, Guid userId)
    {
        modelBuilder.Entity<UserAnimeFavourites>().HasData(
        [
            new UserAnimeFavourites
            {
                Id = Guid.Parse("F7D4BE07-CEFC-48D1-B052-3A3E017ECACB"),
                AnimeId = animeId,
                UserId = userId
            } 
        ]);
    }

    private static Guid SeedUsers(ModelBuilder modelBuilder)
    {
        var userId = Guid.Parse("048DC3FD-DED8-4229-8866-C67B0056432B");
        modelBuilder.Entity<User>().HasData(
        [
            new User
            {
                Id = userId, 
                Username = "Ashley",
                Forename = "Ashley",
                Surname = "Colman",
                GenderId = Gender.Male,
                DateOfBirth = new DateTime(1997, 06, 30),
                ProfileImageUri = "https://scontent.flba1-1.fna.fbcdn.net/v/t39.30808-6/484540404_4716230151849277_3714616557787013077_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=6ee11a&_nc_ohc=GK8Z13XFJmAQ7kNvwFh6JOH&_nc_oc=AdnHoV-enVocHveEBZz3gEq8yHiuApR-KG1_wMu6TRrvH1wurmSQ5bd3tFz-B0dIfre1DeKtGXOqO2TB9EmBFcnj&_nc_zt=23&_nc_ht=scontent.flba1-1.fna&_nc_gid=virFvoFsPT0mfdVL2wjV2Q&oh=00_AYFvaMOOTNn1JFuThUyB1Zd-0RP6Lzx5T8SD7IDlnvZv5Q&oe=67F4BB63"
            } 
        ]);

        return userId;
    }

    private static void SeedAnimeEpisodes(ModelBuilder modelBuilder, Guid animeId, Guid episodeId)
    {
        modelBuilder.Entity<AnimeEpisodes>().HasData(
        [
            new AnimeEpisodes
            {
                Id = Guid.Parse("D776C1EB-1E68-4175-B29A-A32A5278CC8F"),
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
                Id = Guid.Parse("A0B7EF38-8992-45F2-87D9-F2FC83788425"),
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
                Id = Guid.Parse("B5D1D993-A864-4EA8-8D75-C41180A28E70"),
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
                Id = Guid.Parse("71212C3F-19B7-43AA-BD3C-63B036772F2A"),
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
                Id = Guid.Parse("2E17A631-E210-432E-8F0C-D49316422087"),
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
                Id = Guid.Parse("CD6A135A-DA3D-4347-A822-88787037B8E4"),
                AnimeId = animeId,
                GenreId = Genre.Fantasy
            } 
        ]);
    }

    private static void SeedGenders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Anime.Entity.Gender>().HasData(
        [
            new Domain.Anime.Entity.Gender
            {
                Id = Gender.Female,
                Name = "Female"
            },
            new Domain.Anime.Entity.Gender
            {
                Id = Gender.Male,
                Name = "Male"
            },
            new Domain.Anime.Entity.Gender
            {
                Id = Gender.Other,
                Name = "Other"
            }
        ]);
    }

    private static void SeedTags(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Anime.Entity.Tag>().HasData(
        [
            new Domain.Anime.Entity.Tag
            {
                Id = Tag.Fantasy,
                Name = "Fantasy"
            }
        ]);
    }

    private static Guid SeedAnimes(ModelBuilder modelBuilder, Guid animeStatusId, Guid animeTypeId, Guid animeProducerId,
        Guid animeStudioId, Guid seasonId, Guid genreId, Guid viewerRatingId)
    {
        Guid animeId = Guid.Parse("4AFF0276-F322-42EC-B75B-F64851ECFC5E");
        
        modelBuilder.Entity<Anime>().HasData(
        [new Anime
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
                ViewerRatingId = viewerRatingId,
                ImageUri = "https://cdn.myanimelist.net/images/anime/1015/138006.jpg"
            }]);

        return animeId;
    }

    private static Guid SeedCharacters(ModelBuilder modelBuilder)
    {
        Guid characterId = Guid.Parse("8AEDC5AA-53BC-41AC-9463-FED8ACADB4A5");
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
                GenderId = Gender.Female,
                Description = "Frieren is a powerful warrior who has lived for over 1000 years. She is known as the Slayer and is feared by many.",
                ImageUri = "https://cdn.myanimelist.net/images/characters/16/366547.jpg"
            }
        ]);

        return characterId;
    }

    private static Guid SeedEpisodes(ModelBuilder modelBuilder)
    {
        Guid episodeId = Guid.Parse("623A29C5-A1AB-4C3C-A777-18885EE1733B");
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
        Guid genreId = Genre.Fantasy;
        modelBuilder.Entity<Domain.Anime.Entity.Genre>().HasData(
        [
            new Domain.Anime.Entity.Genre
            {
                Id = genreId,
                Name = nameof(Genre.Fantasy)
            }
        ]);
        return genreId;
    }

    private static Guid SeedAnimeSeasons(ModelBuilder modelBuilder)
    {
        Guid seasonId = Domain.Anime.Enums.Season.Fall2025;
        modelBuilder.Entity<Season>().HasData(
        [
            new Season
            {
                Id = seasonId,
                Name = nameof(Domain.Anime.Enums.Season.Fall2025)
            }
        ]);
        return seasonId;
    }

    private static Guid SeedAnimeStudios(ModelBuilder modelBuilder)
    {
        Guid animeStudioId = AnimeStudio.Madhouse;
        modelBuilder.Entity<Studio>().HasData(
        [
            new Studio
            {
                Id = animeStudioId,
                Name = nameof(AnimeStudio.Madhouse)
            }
        ]);
        return animeStudioId;
    }

    private static Guid SeedAnimeProducers(ModelBuilder modelBuilder)
    {
        Guid animeProducerId = AnimeProducer.Aniplex;
        modelBuilder.Entity<Producer>().HasData(
        [
            new Producer
            {
                Id = animeProducerId,
                Name = nameof(AnimeProducer.Aniplex)
            }
        ]);
        return animeProducerId;
    }

    private static Guid SeedAnimeStatuses(ModelBuilder modelBuilder)
    {
        Guid animeStatusId = Domain.Anime.Enums.AnimeStatus.Airing;
        modelBuilder.Entity<AnimeStatus>().HasData(
        [
            new AnimeStatus
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
            new AnimeType
            {
                Id = animeTypeId,
                Name = nameof(Domain.Anime.Enums.AnimeType.TV)
            }
        ]);
        return animeTypeId;
    }
}