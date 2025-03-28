namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeProducers : Entity.Entity
{
    public Guid ProducerId { get; set; }
    public Guid AnimeId { get; set; }
    
    public Entity.Producer Producer { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}