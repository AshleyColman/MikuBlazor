using AutoMapper;
using MediatR;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.DTO.Requests;
using MikuBlazor.Interfaces.Repositories;

namespace MikuBlazor.Application.Character.Queries.Handlers;

public class GetCharacterByIdQueryHandler(
    ICharacterRepository characterRepository,
    IMapper mapper) 
    : IRequestHandler<GetCharacterByIdQuery, CharacterResponse>
{
    public async Task<CharacterResponse> Handle(
        GetCharacterByIdQuery request, 
        CancellationToken cancellationToken)
    {
        CharacterDataGroups[] dataGroups =
        [
            CharacterDataGroups.Anime,
            CharacterDataGroups.Gender
        ];

        Domain.Anime.Entity.Character character =
            await characterRepository.GetByIdAsync(request.Id, asTracking: false, dataGroups)!;

        var response = mapper.Map<CharacterResponse>(character);

        return response;
    }
}