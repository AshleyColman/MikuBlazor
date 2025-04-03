using System.Linq.Expressions;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Domain.Anime.JoinEntity;

namespace MikuBlazor.Application.Profile.Queries.Projections;

public static class Projections
{
    public static Expression<Func<User, User>> GetAllProfilesQueryProjection()
    {
        return x => new User
        {
            Username = x.Username
        };
    }
    
    public static Expression<Func<User, User>> GetProfileByIdQueryProjection()
    {
        return x => new User
        {
            Id = x.Id,
            Username = x.Username,
            Forename = x.Forename,
            Surname = x.Surname,
            GenderId = x.GenderId,
            DateOfBirth = x.DateOfBirth,
            
            Gender = new Gender
            {
                Id = x.GenderId,
                Name = x.Gender.Name
            },
            
            AnimeFavourites = x.AnimeFavourites.Select(af => new UserAnimeFavourites
            {
                Id = af.Id,
                AnimeId = af.AnimeId,
                Anime = new Domain.Anime.Entity.Anime
                {
                    ImageUri = af.Anime.ImageUri,
                },
                UserId = af.UserId
            }).ToList(),
            
            AnimeRatings = x.AnimeRatings.Select(ar => new UserAnimeRatings
            {
                Id = ar.Id,
                AnimeId = ar.AnimeId,
                Anime = new Domain.Anime.Entity.Anime
                {
                    ImageUri = ar.Anime.ImageUri
                },
                Rating = ar.Rating,
                UserId = ar.UserId
            }).ToList(),
            
            CharacterFavourites = x.CharacterFavourites.Select(cf => new UserCharacterFavourites
            {
                Id = cf.Id,
                UserId = cf.UserId,
                Character = new Domain.Anime.Entity.Character
                {
                    FirstName = cf.Character.FirstName,
                    LastName = cf.Character.LastName,
                    NickName = cf.Character.NickName,
                    ImageUri = cf.Character.ImageUri
                },
                CharacterId = cf.CharacterId
            }).ToList()
        };
    }
}