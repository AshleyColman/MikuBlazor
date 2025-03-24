using MediatR;
using Microsoft.AspNetCore.Mvc;
using MikuBlazor.Application.Anime.Queries;
using MikuBlazor.DTO.Requests;

namespace MikuBlazor.Controllers;

[ApiController]
[Route("api/anime")]
public class AnimeController(ISender sender) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IList<AnimeResponse>>> GetAllAnime()
    {
        IList<AnimeResponse> result = await sender.Send(new GetAllAnimeQuery());

        return Ok(result);
    }
    
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<AnimeResponse>> GetAnimeById(Guid id)
    {
        AnimeResponse result = await sender.Send(new GetAnimeByIdQuery(id));

        return Ok(result);
    }
}