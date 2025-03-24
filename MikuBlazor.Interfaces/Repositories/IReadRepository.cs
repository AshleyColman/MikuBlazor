using System.Linq.Expressions;
using System.Reflection.Metadata;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Interfaces.Repositories;

public interface IReadRepository<T> where T : Entity
{
    Task<IList<T>> GetAllAsync(Expression<Func<T, T>>? select, bool asTracking);
    Task<T?> GetByIdAsync(Guid id, bool asTracking);
}