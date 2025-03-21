namespace MikuBlazor.Domain.Anime.Entity;

public class Gender : Entity
{
    public required string Name { get; set; } = null!;

    public IList<Character> Characters { get; set; } = [];
}