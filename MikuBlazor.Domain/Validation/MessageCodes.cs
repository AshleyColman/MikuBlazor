namespace MikuBlazor.Domain.Validation;

public static class MessageCodes
{
    public static string NotEmpty(string fieldName) => $"{fieldName} cannot be empty";
}