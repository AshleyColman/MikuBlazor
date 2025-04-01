namespace MikuBlazor.DTO.Requests.GetProfile;

public sealed class AnimeFavouriteResponse
{
    public Guid AnimeId { get; set; }
    public Domain.Anime.Entity.Anime Anime { get; set; } = null!;
}