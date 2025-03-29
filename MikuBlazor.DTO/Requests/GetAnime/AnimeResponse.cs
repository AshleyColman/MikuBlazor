using MikuBlazor.DTO.Requests.Shared;

namespace MikuBlazor.DTO.Requests.GetAnime;

public sealed class AnimeResponse
{
    public Guid Id { get; init; }
    public string Title { get; init; } = null!;
    public string JapaneseTitle { get; init; } = null!;
    public byte Rating { get; init; }
    public UInt16 Rank { get; init; }
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }
    public IReadOnlyList<EpisodeResponse> Episodes { get; set; } = [];
    public AnimeTypeResponse Type { get; init; } = null!;
    public AnimeStatusResponse Status { get; set; } = null!;
    public IReadOnlyList<ProducerResponse> Producers = [];
    public IReadOnlyList<TagResponse> Tags { get; init; } = [];
    public IReadOnlyList<StudioResponse> Studio { get; init; } = [];
    public SeasonResponse Season { get; init; } = null!;
    public IReadOnlyList<GenreResponse> Genres { get; init; } = [];
    public ViewerRatingResponse ViewerRating { get; init; } = null!;
}