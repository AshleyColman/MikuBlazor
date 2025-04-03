namespace MikuBlazor.DTO.Responses.GetAnime;

public sealed class EpisodeResponse
{
    public Guid Id { get; init; }
    public string Title { get; init; } = null!;
    public string Description { get; init; } = null!;
    public UInt16 Number { get; init; }
}