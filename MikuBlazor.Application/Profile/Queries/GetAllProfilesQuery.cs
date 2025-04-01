using MediatR;
using MikuBlazor.DTO.Requests.GetProfile;

namespace MikuBlazor.Application.Profile.Queries;

public record GetAllProfilesQuery : IRequest<IList<ProfileResponse>>;