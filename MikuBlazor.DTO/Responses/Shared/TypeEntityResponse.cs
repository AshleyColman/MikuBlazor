namespace MikuBlazor.DTO.Responses.Shared;

public abstract class TypeEntityResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}