using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class UserCharacterFavourites : Entity.Entity
{
    public required Guid UserId { get; set; }
    public required Guid CharacterId { get; set; }

    public User User { get; set; } = null!;
    public Character Character { get; set; } = null!;
}