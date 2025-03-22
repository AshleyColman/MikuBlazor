namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeProducers : Entity.Entity
{
    public required Guid ProducerId { get; set; }
    public required Guid AnimeId { get; set; }
    
    public Entity.Producer Producer { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}