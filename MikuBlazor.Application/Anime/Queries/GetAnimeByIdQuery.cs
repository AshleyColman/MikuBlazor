using MediatR;
using MikuBlazor.DTO.Requests;

namespace MikuBlazor.Application.Anime.Queries;

public record GetAnimeByIdQuery(Guid Id) : IRequest<AnimeResponse>;