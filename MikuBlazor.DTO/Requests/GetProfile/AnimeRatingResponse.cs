using System.Security.AccessControl;

namespace MikuBlazor.DTO.Requests.GetProfile;

public sealed class AnimeRatingResponse
{
    public byte Rating { get; set; }
    public Guid AnimeId { get; set; }
    public Domain.Anime.Entity.Anime Anime { get; set; } = null!;
}