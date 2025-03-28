namespace MikuBlazor.Domain.Anime.Entity;

public class Episode : Entity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public UInt16 Number { get; set; }

    public IList<Anime> Animes { get; set; } = [];
} 