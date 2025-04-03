using MediatR;
using Microsoft.AspNetCore.Mvc;
using MikuBlazor.Application.Profile.Queries;
using MikuBlazor.DTO.Responses.GetProfile;

namespace MikuBlazor.Controllers;

[ApiController]
[Route("api/profile")]
public class ProfileController(ISender sender) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProfileResponse>> GetProfileById([FromRoute] Guid id)
    {
        ProfileResponse result = await sender.Send(new GetProfileByIdQuery(id));

        return Ok(result);
    }
}