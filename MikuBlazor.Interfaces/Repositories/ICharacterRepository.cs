using System.Linq.Expressions;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Interfaces.Repositories;

public interface ICharacterRepository : IReadRepository<Character>
{
    Task<Character?> GetByIdAsync(Guid id, bool asTracking, Expression<Func<Character, Character>>? select, params CharacterDataGroups[] dataGroups);
}