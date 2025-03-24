namespace MikuBlazor.DTO.Requests;

public class CharacterResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string NickName { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public UInt16 Age { get; set; }
    public string Description { get; set; } = null!;
    public string ImageUri { get; set; } = null!;
}