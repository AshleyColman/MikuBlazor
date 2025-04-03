using MikuBlazor.DTO.Responses.GetCharacter;

namespace MikuBlazor.DTO.Responses.GetProfile;

public sealed class ProfileResponse
{
    public string Username { get; init; } = null!;
    public string Forename { get; init; } = null!;
    public string Surname { get; init; } = null!;
    public string Gender { get; init; } = null!;
    public DateTime DateOfBirth { get; init; }

    public IList<AnimeFavouriteResponse> AnimeFavourites { get; init; } = [];
    public IList<AnimeRatingResponse> AnimeRatings { get; init; } = [];
    public IList<CharacterFavouriteResponse> CharacterFavourites { get; init; } = [];
}