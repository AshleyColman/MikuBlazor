using AutoMapper;
using MediatR;
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
        Domain.Anime.Entity.Anime anime = await animeRepository.GetByIdAsync(request.Id, asTracking: false)!;

        var response = mapper.Map<AnimeResponse>(anime);

        return response;
    }
}