namespace MikuBlazor.DTO.Requests;

public sealed class AnimeResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string JapaneseTitle { get; set; } = null!;
    public byte Rating { get; set; }
    public UInt16 Rank { get; set; }
    // public UInt16 Episodes { get; set; }
    public Guid StatusId { get; set; }
    public string Type { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid ProducerId { get; set; }
    public string Producer { get; set; } = null!;
    public Guid StudioId { get; set; }
    public string Studio { get; set; } = null!;
    public Guid SeasonId { get; set; }
    public string Season { get; set; } = null!;
    public Guid GenreId { get; set; }
    public string Genre { get; set; } = null!;
    public string ViewerRating { get; set; } = null!;
}