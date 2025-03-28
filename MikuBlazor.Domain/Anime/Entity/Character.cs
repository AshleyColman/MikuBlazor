using System.Diagnostics.CodeAnalysis;

namespace MikuBlazor.Domain.Anime.Entity;

public sealed class Character : Entity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? NickName { get; set; }
    public string JapaneseName { get; set; } = null!;
    public Guid GenderId { get; set; }
    public UInt16 Age { get; set; }
    public string Description { get; set; } = null!;
    public string ImageUri { get; set; } = null!;

    public IList<Anime> Animes { get; set; } = [];
    public Gender Gender { get; set; } = null!;
}