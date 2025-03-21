using MediatR;
using MikuBlazor.DTO.Requests;

namespace MikuBlazor.Application.Anime.Queries;

public record GetAllAnimeQuery : IRequest<IList<AnimeResponse>>;