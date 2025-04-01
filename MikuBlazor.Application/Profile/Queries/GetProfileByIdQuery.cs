using MediatR;
using MikuBlazor.DTO.Requests;
using MikuBlazor.DTO.Requests.GetProfile;

namespace MikuBlazor.Application.Profile.Queries;

public record GetProfileByIdQuery(Guid Id) : IRequest<ProfileResponse>;