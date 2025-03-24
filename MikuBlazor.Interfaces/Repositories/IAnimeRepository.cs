using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Interfaces.Repositories;

public interface IAnimeRepository : IReadRepository<Anime>
{
    Task<Anime?> GetByIdAsync(Guid id, bool asTracking, AnimeDataGroups[] dataGroups);
}