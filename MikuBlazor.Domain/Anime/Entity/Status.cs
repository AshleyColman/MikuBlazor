namespace MikuBlazor.Domain.Anime.Entity;

public sealed class Status : Entity
{
    public required string Name { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}