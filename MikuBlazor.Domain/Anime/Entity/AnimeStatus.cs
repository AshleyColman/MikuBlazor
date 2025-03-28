namespace MikuBlazor.Domain.Anime.Entity;

public sealed class AnimeStatus : Entity
{
    public string Name { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}