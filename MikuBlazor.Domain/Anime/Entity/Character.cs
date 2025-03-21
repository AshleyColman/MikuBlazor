namespace MikuBlazor.Domain.Anime.Entity;

public sealed class Character : Entity
{
    public required string FirstName { get; set; } = null!;
    public required string LastName { get; set; } = null!;
    public string? NickName { get; set; }
    public required string JapaneseName { get; set; } = null!;
    public required Gender Gender { get; set; }
    public required UInt16 Age { get; set; }
    public required string Description { get; set; } = null!;
    public required string ImageUri { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
}