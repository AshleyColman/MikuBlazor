using MediatR;
using MikuBlazor.DTO.Responses.GetProfile;

namespace MikuBlazor.Application.Profile.Queries;

public record GetProfileByIdQuery(Guid Id) : IRequest<ProfileResponse>;