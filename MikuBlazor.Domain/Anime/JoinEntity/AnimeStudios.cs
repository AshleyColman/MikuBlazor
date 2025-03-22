namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeStudios : Entity.Entity
{
    public required Guid StudioId { get; set; }
    public required Guid AnimeId { get; set; }
    
    public Entity.Studio Studio { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}