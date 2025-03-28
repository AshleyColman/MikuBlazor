namespace MikuBlazor.Domain.Anime.Entity;

public class Season : Entity
{
    public string Name { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}