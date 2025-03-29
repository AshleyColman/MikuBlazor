using MikuBlazor.DTO.Requests.Shared;

namespace MikuBlazor.DTO.Requests.GetAnime;

public sealed class EpisodeResponse
{
    public Guid Id { get; init; }
    public string Title { get; init; } = null!;
    public string Description { get; init; } = null!;
    public UInt16 Number { get; init; }
}