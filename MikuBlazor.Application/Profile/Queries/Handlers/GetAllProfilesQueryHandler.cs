using AutoMapper;
using MediatR;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.DTO.Requests.GetProfile;
using MikuBlazor.Interfaces.Repositories;

namespace MikuBlazor.Application.Profile.Queries.Handlers;

public sealed class GetAllProfilesQueryHandler(
    IUserRepository userRepository,
    IMapper mapper) 
    : IRequestHandler<GetAllProfilesQuery, IList<ProfileResponse>> 
{
    public async Task<IList<ProfileResponse>> Handle(GetAllProfilesQuery request, CancellationToken cancellationToken)
    {
        IList<User> users = await userRepository.GetAllAsync(
            Projections.Projections.GetAllProfilesQueryProjection(),
            asTracking: false);

        var response = mapper.Map<IList<ProfileResponse>>(users);

        return response;
    }
}