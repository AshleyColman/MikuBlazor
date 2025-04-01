using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.DTO.Requests.GetProfile;

public sealed class CharacterFavouriteResponse
{
    public Guid CharacterId { get; set; }
    public Character Character { get; set; } = null!;
}