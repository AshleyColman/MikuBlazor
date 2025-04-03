namespace MikuBlazor.DTO.Responses.GetProfile;

public sealed class AnimeFavouriteResponse
{
    public Guid AnimeId { get; init; }
    public string ImageUri { get; init; } = null!;    
}