using MediatR;
using MikuBlazor.DTO.Responses.GetAnime;

namespace MikuBlazor.Application.Anime.Queries;

public record GetAnimeByIdQuery(Guid Id) : IRequest<AnimeResponse>;