using MediatR;
using MikuBlazor.DTO.Responses.GetCharacter;

namespace MikuBlazor.Application.Character.Queries;

public record GetCharacterByIdQuery(Guid Id) : IRequest<CharacterResponse>;