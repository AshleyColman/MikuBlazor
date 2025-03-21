namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeTags : Entity.Entity
{
    public required Guid TagId { get; set; }
    public required Guid AnimeId { get; set; }
    
    public Entity.Tag Tag { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}