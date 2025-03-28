namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class UserAnimeRatings : Entity.Entity
{
    public Guid UserId { get; set; }
    public Guid AnimeId { get; set; }
    public byte Rating { get; set; }

    public Entity.User User { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}