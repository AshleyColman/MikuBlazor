namespace MikuBlazor.DTO.Requests;

public sealed class AnimeResponse
{
    public required string Title { get; set; } = null!;
    public required string JapaneseTitle { get; set; } = null!;
    public required byte Rating { get; set; }
    public required UInt16 Rank { get; set; }
    public required UInt16 Episodes { get; set; }
    public required Guid StatusId { get; set; }
    public required Guid TypeId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public required Guid ProducerId { get; set; }
    public required Guid StudioId { get; set; }
    public required Guid SeasonId { get; set; }
    public required Guid GenreId { get; set; }
    public required Guid ViewerRatingId { get; set; }   
}