namespace MikuBlazor.Domain.Anime.Entity;

// Rating e.g PG
public sealed class ViewerRating : Entity
{
    public required string Name { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}