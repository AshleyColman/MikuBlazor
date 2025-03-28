namespace MikuBlazor.Domain.Anime.JoinEntity;

public sealed class AnimeGenres : Entity.Entity
{
    public Guid GenreId { get; set; }
    public Guid AnimeId { get; set; }
    
    public Entity.Genre Genre { get; set; } = null!;
    public Entity.Anime Anime { get; set; } = null!;
}