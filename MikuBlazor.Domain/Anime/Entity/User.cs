using MikuBlazor.Domain.Anime.JoinEntity;

namespace MikuBlazor.Domain.Anime.Entity;

public sealed class User : Entity
{
    public string Username { get; set; } = null!;
    public string Forename { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public Guid GenderId { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ProfileImageUri { get; set; } = null!;

    public Gender Gender { get; set; } = null!;
    public IList<UserAnimeFavourites> AnimeFavourites { get; set; } = [];
    public IList<UserAnimeRatings> AnimeRatings { get; set; } = [];
    public IList<UserCharacterFavourites> CharacterFavourites { get; set; } = [];
}