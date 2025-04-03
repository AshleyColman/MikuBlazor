using MediatR;
using Microsoft.AspNetCore.Mvc;
using MikuBlazor.Application.Character.Queries;
using MikuBlazor.DTO.Responses.GetCharacter;

namespace MikuBlazor.Controllers;

[ApiController]
[Route("api/character")]
public class CharacterController(ISender sender) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IList<CharacterResponse>>> GetCharacters()
    {
        var result = await sender.Send(new GetAllCharactersQuery());

        return Ok(result);
    }
    
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CharacterResponse>> GetCharacterById(Guid id)
    {
        CharacterResponse result = await sender.Send(new GetCharacterByIdQuery(id));

        return Ok(result);
    }
}