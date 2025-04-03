using AutoMapper;
using MediatR;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.DTO.Responses.GetProfile;
using MikuBlazor.Interfaces.Repositories;

namespace MikuBlazor.Application.Profile.Queries.Handlers;

public class GetProfileByIdQueryHandler(
    IUserRepository userRepository,
    IMapper mapper)
    : IRequestHandler<GetProfileByIdQuery, ProfileResponse>
{
    public async Task<ProfileResponse> Handle(
        GetProfileByIdQuery request,
        CancellationToken cancellationToken)
    {
        UserDataGroups[] dataGroups =
        [
            UserDataGroups.AnimeFavourites,
            UserDataGroups.CharacterFavourites,
            UserDataGroups.AnimeRatings
        ];

        User user = await userRepository.GetByIdAsync(
            request.Id, 
            asTracking: false,
            Projections.Projections.GetProfileByIdQueryProjection(),
            dataGroups)!;

        var response = mapper.Map<ProfileResponse>(user);

        return response;
    }
}