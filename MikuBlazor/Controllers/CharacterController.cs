using MediatR;
using Microsoft.AspNetCore.Mvc;
using MikuBlazor.Application.Anime.Queries;
using MikuBlazor.DTO.Requests;

namespace MikuBlazor.Controllers;

[ApiController]
[Route("api/character")]
public class CharacterController(ISender sender) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CharacterResponse>> GetCharacterById(Guid id)
    {
        AnimeResponse result = await sender.Send(new GetAnimeByIdQuery(id));

        return Ok(result);
    }
}