using System.Linq.Expressions;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Application.Character.Queries.Projections;

public static class Projections
{
    public static Expression<Func<Domain.Anime.Entity.Character, Domain.Anime.Entity.Character>>
        GetAllCharactersQueryProjection()
    {
        return x => new Domain.Anime.Entity.Character
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            NickName = x.NickName,
            JapaneseName = x.JapaneseName,
            Description = x.Description,
            ImageUri = x.ImageUri,
        };
    }
    
    public static Expression<Func<Domain.Anime.Entity.Character, Domain.Anime.Entity.Character>>
        GetCharacterByIdQueryProjection()
    {
        return x => new Domain.Anime.Entity.Character
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            NickName = x.NickName,
            JapaneseName = x.JapaneseName,
            Gender = new Gender
            {
                Name = x.Gender.Name
            },
            Age = x.Age,
            Description = x.Description,
            ImageUri = x.ImageUri,
            Animes = x.Animes.Select(a => new Domain.Anime.Entity.Anime
            {
                Title = a.Title
            }).ToList()
        };
    }
}