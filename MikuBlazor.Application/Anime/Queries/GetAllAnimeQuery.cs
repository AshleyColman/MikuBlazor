using MediatR;
using MikuBlazor.DTO.Requests;
using MikuBlazor.DTO.Requests.GetAnime;

namespace MikuBlazor.Application.Anime.Queries;

public record GetAllAnimeQuery : IRequest<IList<AnimeResponse>>;