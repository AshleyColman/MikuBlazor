using MediatR;
using MikuBlazor.DTO.Requests.GetAnime;

namespace MikuBlazor.Application.Anime.Queries;

public record GetAnimeByIdQuery(Guid Id) : IRequest<AnimeResponse>;