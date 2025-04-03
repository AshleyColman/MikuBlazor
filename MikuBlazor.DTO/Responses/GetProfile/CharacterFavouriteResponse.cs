

namespace MikuBlazor.DTO.Responses.GetProfile;

public sealed class CharacterFavouriteResponse
{
    public Guid CharacterId { get; init; }
    public string FirstName { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public string NickName { get; init; } = null!;
    public string ImageUri { get; init; } = null!;
}