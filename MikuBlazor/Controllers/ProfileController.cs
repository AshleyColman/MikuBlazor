using MediatR;
using Microsoft.AspNetCore.Mvc;
using MikuBlazor.Application.Anime.Queries;
using MikuBlazor.Application.Profile.Queries;
using MikuBlazor.DTO.Requests;
using MikuBlazor.DTO.Requests.GetProfile;

namespace MikuBlazor.Controllers;

[ApiController]
[Route("api/profile")]
public class ProfileController(ISender sender) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProfileResponse>> GetProfileById(Guid id)
    {
        var result = await sender.Send(new GetProfileByIdQuery(id));

        return Ok(result);
    }
}