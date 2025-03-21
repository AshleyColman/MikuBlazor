namespace MikuBlazor.Domain.Anime.Entity;

public sealed class Season
{
    public required string Name { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}