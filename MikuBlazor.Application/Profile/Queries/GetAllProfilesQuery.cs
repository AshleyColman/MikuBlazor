using MediatR;
using MikuBlazor.DTO.Responses.GetProfile;

namespace MikuBlazor.Application.Profile.Queries;

public record GetAllProfilesQuery : IRequest<IList<ProfileResponse>>;