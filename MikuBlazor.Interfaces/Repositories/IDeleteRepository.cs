using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Interfaces.Repositories;

public interface IDeleteRepository<T> where T : Entity
{
    Task DeleteAsync(T entity);
}