

using MikuBlazor.Domain.Anime.JoinEntity;

namespace MikuBlazor.Domain.Anime.Entity;

public sealed class Anime : Entity
{
    public string Title { get; set; } = null!;
    public string JapaneseTitle { get; set; } = null!;
    public byte Rating { get; set; }
    public UInt16 Rank { get; set; }
    public UInt16 Episodes { get; set; }
    public Guid StatusId { get; set; }
    public Guid TypeId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid ProducerId { get; set; }
    public Guid StudioId { get; set; }
    public Guid SeasonId { get; set; }
    public Guid GenreId { get; set; }
    public Guid ViewerRatingId { get; set; }
    
    public AnimeStatus Status { get; set; } = null!;
    public AnimeType Type { get; set; } = null!;
    public Season Season { get; set; } = null!;
    public ViewerRating ViewerRating { get; set; } = null!;
    public IList<Genre> Genres { get; set; } = [];
    public IList<Producer> Producers { get; set; } = [];
    public IList<Studio> Studios { get; set; } = [];
    public IList<Character> Characters { get; set; } = [];
    public IList<Tag> Tags { get; set; } = [];
    public IList<UserAnimeFavourites> UserAnimeFavourites { get; set; } = [];
    public IList<UserAnimeRatings> UserAnimeRatings { get; set; } = [];
    public IList<UserCharacterFavourites> UserCharacterFavouritesList { get; set; } = [];
}