namespace MikuBlazor.Domain.Anime.Entity;

public class Gender : Entity
{
    public string Name { get; set; } = null!;

    public IList<Character> Characters { get; set; } = [];
}