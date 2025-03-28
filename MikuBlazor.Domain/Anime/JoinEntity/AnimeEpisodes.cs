namespace MikuBlazor.Domain.Anime.JoinEntity;

public class AnimeEpisodes : Entity.Entity
{
    public Guid AnimeId { get; set; }
    public Guid EpisodeId { get; set; }

    public Entity.Anime Anime { get; set; } = null!;
    public Entity.Episode Episode { get; set; } = null!;
}