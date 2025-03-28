namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeStudios : Entity.Entity
{
    public Guid StudioId { get; set; }
    public Guid AnimeId { get; set; }
    
    public Entity.Studio Studio { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}