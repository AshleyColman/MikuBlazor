namespace MikuBlazor.DTO.Responses.GetProfile;

public sealed class AnimeRatingResponse
{
    public Guid AnimeId { get; init; }
    public string ImageUri { get; init; } = null!;    
    public byte Rating { get; init; }
}