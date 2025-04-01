namespace MikuBlazor.DTO.Requests.GetCharacter;

public class CharacterResponse
{
    public Guid Id { get; init; }
    public string FirstName { get; init; } = null!;
    public string LastName { get; init; } = null!;
    public string NickName { get; init; } = null!;
    public UInt16 Age { get; init; }
    public string Description { get; init; } = null!;
    public string ImageUri { get; init; } = null!;
    public GenderResponse Gender { get; init; } = null!;
}