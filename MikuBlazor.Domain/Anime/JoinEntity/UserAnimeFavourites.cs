
namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class UserAnimeFavourites : Entity.Entity
{
    public Guid UserId { get; set; }
    public Guid AnimeId { get; set; }

    public Entity.User User { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}