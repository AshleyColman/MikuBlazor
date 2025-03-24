using MediatR;
using MikuBlazor.DTO.Requests;

namespace MikuBlazor.Application.Character.Queries;

public record GetCharacterByIdQuery(Guid Id) : IRequest<CharacterResponse>;