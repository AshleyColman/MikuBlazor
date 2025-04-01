using MediatR;

namespace MikuBlazor.Application.Character.Queries;

public record GetAllCharactersQuery : IRequest<IList<Domain.Anime.Entity.Character>>;