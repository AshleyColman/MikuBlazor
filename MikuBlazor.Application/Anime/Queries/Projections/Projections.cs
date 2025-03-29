using System.Linq.Expressions;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Application.Anime.Queries.Projections;

public static class Projections
{
    public static Expression<Func<Domain.Anime.Entity.Anime, Domain.Anime.Entity.Anime>> GetAllAnimeQueryProjection()
    {
        return x => new Domain.Anime.Entity.Anime
        {
            Id = x.Id,
            Title = x.Title,
            JapaneseTitle = x.JapaneseTitle,
            Rating = x.Rating,
            Rank = x.Rank,
            Episodes = x.Episodes,
            StatusId = x.StatusId,
            TypeId = x.TypeId,
            StartDate = x.StartDate,
            EndDate = x.EndDate,
            SeasonId = x.SeasonId,
            ViewerRatingId = x.ViewerRatingId
        };
    }
    
    public static Expression<Func<Domain.Anime.Entity.Anime, Domain.Anime.Entity.Anime>> GetAnimeByIdQueryProjection()
    {
        return x => new Domain.Anime.Entity.Anime
        {
            Id = x.Id,
            Title = x.Title,
            JapaneseTitle = x.JapaneseTitle,
            Rating = x.Rating,
            Rank = x.Rank,
            StatusId = x.StatusId,
            TypeId = x.TypeId,
            StartDate = x.StartDate,
            EndDate = x.EndDate,
            SeasonId = x.SeasonId,
            ViewerRatingId = x.ViewerRatingId,
            Status = new AnimeStatus
            {
                Id = x.Id,
                Name = x.Status.Name
            },
            Type = new AnimeType
            {
                Id = x.Id,
                Name = x.Type.Name
            },
            Season = new Season
            {
                Id = x.Id,
                Name = x.Season.Name
            },
            ViewerRating = new ViewerRating
            {
                Id = x.Id,
                Name = x.ViewerRating.Name
            },
            Characters = x.Characters.Select(c => new Domain.Anime.Entity.Character
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                NickName = c.NickName,
                JapaneseName = c.JapaneseName,
                GenderId = c.GenderId,
                Age = c.Age,
                Description = c.Description,
                ImageUri = c.ImageUri
            }).ToList(),
            Genres = x.Genres.Select(g => new Genre
            {
                Id = g.Id,
                Name = g.Name
            }).ToList(),
            Producers = x.Producers.Select(p => new Producer
            {
                Id = p.Id,
                Name = p.Name
            }).ToList(),
            Studios = x.Studios.Select(s => new Studio
            {
                Id = s.Id,
                Name = s.Name
            }).ToList(),
            Episodes = x.Episodes.Select(e => new Episode
            {
                Id = e.Id,
                Title = e.Title,
                Description = e.Description,
                Number = e.Number
            }).ToList(),
            Tags = x.Tags.Select(t => new Tag
            {
                Id = t.Id,
                Name = t.Name
            }).ToList()
        };
    }
}