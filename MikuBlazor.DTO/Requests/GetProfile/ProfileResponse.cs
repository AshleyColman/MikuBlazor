namespace MikuBlazor.DTO.Requests.GetProfile;

public sealed class ProfileResponse
{
    public string Username { get; set; } = null!;
    public string Forename { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }

    public IList<AnimeFavouriteResponse> AnimeFavourites { get; set; } = [];
    public IList<AnimeRatingResponse> AnimeRatings { get; set; } = [];
    public IList<CharacterResponse> CharacterResponses { get; set; } = [];
}