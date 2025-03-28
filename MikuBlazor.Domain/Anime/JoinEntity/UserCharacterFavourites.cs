using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class UserCharacterFavourites : Entity.Entity
{
    public Guid UserId { get; set; }
    public Guid CharacterId { get; set; }

    public User User { get; set; } = null!;
    public Character Character { get; set; } = null!;
}