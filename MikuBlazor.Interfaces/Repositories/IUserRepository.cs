using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Interfaces.Repositories;

public interface IUserRepository : IReadRepository<User>
{
    Task<User?> GetByIdAsync(Guid id, bool asTracking, params UserDataGroups[] dataGroups);
}