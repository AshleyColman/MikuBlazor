using MediatR;
using MikuBlazor.DTO.Requests;

namespace MikuBlazor.Application.Profile.Queries;

public record GetProfileByIdQuery(Guid Id) : IRequest<ProfileResponse>;