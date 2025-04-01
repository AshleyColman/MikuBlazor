using AutoMapper;
using MediatR;
using MikuBlazor.Interfaces.Repositories;

namespace MikuBlazor.Application.Character.Queries.Handlers;

public sealed class GetAllCharactersQueryHandler(
    ICharacterRepository characterRepository,
    IMapper mapper) 
    : IRequestHandler<GetAllCharactersQuery, IList<Domain.Anime.Entity.Character>>
{
    public async Task<IList<Domain.Anime.Entity.Character>> Handle(
        GetAllCharactersQuery request, 
        CancellationToken cancellationToken)
    {
        IList<Domain.Anime.Entity.Character> characters = 
            await characterRepository.GetAllAsync(
                Projections.Projections.GetAllCharactersQueryProjection(),
                asTracking: false);
        
        var response = mapper.Map<IList<Domain.Anime.Entity.Character>>(characters);

        return response;
    }
}