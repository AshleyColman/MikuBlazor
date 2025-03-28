namespace MikuBlazor.Domain.Anime.Entity;

public sealed class AnimeType : Entity
{
    public string Name { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}