namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeCharacters : Entity.Entity
{
    public required Guid CharacterId { get; set; }
    public required Guid AnimeId { get; set; }
    
    public Entity.Character Character { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}