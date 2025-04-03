using MediatR;
using MikuBlazor.DTO.Responses.GetAnime;

namespace MikuBlazor.Application.Anime.Queries;

public record GetAllAnimeQuery : IRequest<IList<AnimeResponse>>;