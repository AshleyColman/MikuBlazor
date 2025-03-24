using AutoMapper;
using MediatR;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.DTO.Requests;
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
            AnimeDataGroups.Characters
        ];
        
        Domain.Anime.Entity.Anime anime = await animeRepository.GetByIdAsync(request.Id, asTracking: false, dataGroups)!;

        var response = mapper.Map<AnimeResponse>(anime);

        return response;
    }
}