namespace MikuBlazor.Domain.Anime.Entity;

public sealed class Producer : Entity
{
    public string Name { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}