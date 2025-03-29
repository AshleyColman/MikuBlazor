using AutoMapper;
using MediatR;
using MikuBlazor.DTO.Requests;
using MikuBlazor.DTO.Requests.GetAnime;
using MikuBlazor.Interfaces.Repositories;

namespace MikuBlazor.Application.Anime.Queries.Handlers;

public class GetAllAnimeQueryHandler(
    IAnimeRepository animeRepository,
    IMapper mapper) 
    : IRequestHandler<GetAllAnimeQuery, IList<AnimeResponse>>
{
    public async Task<IList<AnimeResponse>> Handle(
        GetAllAnimeQuery request, 
        CancellationToken cancellationToken)
    {
        IList<Domain.Anime.Entity.Anime> animes = await animeRepository.GetAllAsync(
            Projections.Projections.GetAllAnimeQueryProjection(), asTracking: false);

        var response = mapper.Map<IList<AnimeResponse>>(animes);

        return response;
    }
}