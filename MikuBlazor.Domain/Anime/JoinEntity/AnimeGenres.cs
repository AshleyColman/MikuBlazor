namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeGenres : Entity.Entity
{
    public required Guid GenreId { get; set; }
    public required Guid AnimeId { get; set; }
    
    public Entity.Genre Genre { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}