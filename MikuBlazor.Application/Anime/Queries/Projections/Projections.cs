using System.Linq.Expressions;

namespace MikuBlazor.Application.Anime.Queries.Projections;

public static class Projections
{
    public static Expression<Func<Domain.Anime.Entity.Anime, Domain.Anime.Entity.Anime>> GetAllAnimeQueryProjection()
    {
        return x => new Domain.Anime.Entity.Anime
        {
            Title = x.Title,
            JapaneseTitle = x.JapaneseTitle,
            Rating = x.Rating,
            Rank = x.Rank,
            Episodes = x.Episodes,
            StatusId = x.StatusId,
            TypeId = x.TypeId,
            StartDate = x.StartDate,
            EndDate = x.EndDate,
            ProducerId = x.ProducerId,
            StudioId = x.StudioId,
            SeasonId = x.SeasonId,
            GenreId = x.GenreId,
            ViewerRatingId = x.ViewerRatingId
        };
    }
}