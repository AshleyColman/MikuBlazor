using MikuBlazor.Domain.Anime.JoinEntity;

namespace MikuBlazor.Domain.Anime.Entity;

public sealed class User : Entity
{
    public required string Username { get; set; } = null!;

    public IList<UserAnimeFavourites> AnimeFavourites { get; set; } = [];
    public IList<UserAnimeRatings> AnimeRatings { get; set; } = [];
    public IList<UserCharacterFavourites> UserCharacterFavourites { get; set; } = [];
}