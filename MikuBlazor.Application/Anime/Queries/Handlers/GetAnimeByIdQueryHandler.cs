using AutoMapper;
using MediatR;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.DTO.Responses.GetAnime;
using MikuBlazor.Interfaces.Repositories;

namespace MikuBlazor.Application.Anime.Queries.Handlers;

public class GetAnimeByIdQueryHandler(
    IAnimeRepository animeRepository,
    
    IMapper mapper) 
    : IRequestHandler<GetAnimeByIdQuery, AnimeResponse>
{
    public async Task<AnimeResponse> Handle(GetAnimeByIdQuery request, CancellationToken cancellationToken)
    {
        AnimeDataGroups[] dataGroups =
        [
            AnimeDataGroups.Characters,
            AnimeDataGroups.Type,
            AnimeDataGroups.Status,
            AnimeDataGroups.Producer,
            AnimeDataGroups.Studio,
            AnimeDataGroups.Season,
            AnimeDataGroups.ViewerRating,
            AnimeDataGroups.Episodes,
            AnimeDataGroups.Genres,
            AnimeDataGroups.Tags
        ];
        
        Domain.Anime.Entity.Anime anime = await animeRepository.GetByIdAsync(
            request.Id, 
            asTracking: false,
            Projections.Projections.GetAnimeByIdQueryProjection(),
            dataGroups)!;

        var response = mapper.Map<AnimeResponse>(anime);
        
        return response;
    }
}